<?php

namespace App\Http\Controllers\rendszerfejlesztes;

use App\Http\Controllers\Controller;
use App\Models\productmodel;
use http\Exception\BadQueryStringException;
use Illuminate\Database\QueryException;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class productcontroller extends Controller
{
    public function pricemod(Request $req, productmodel $product)
    {
        $product->update($req->all());

        return response()->json($product, 200);
    }

    public  function createproduct(Request $req)
    {
        $prod=productmodel::create($req->all());
        return response()->json($prod,201);
    }

    public function modifyprice(Request $req, $ProductName)
    {
        $product=DB::table('products')->where('ProductName', $ProductName);


        if($product==null)
        {
            return  response()->json(['message'=>"record not found"],404);
        }
        $product->update(['Price'=>$req->input('price')]);



        return response()->json(['message'=>'record update successfully'], 200);
    }

    public function modquantity(Request $req, $name)
    {
        $product= DB::table('products')->where('ProductName', $name);
        if($product!=null)
        {
            $product->update(['Quantity'=>$req->input('newquantity')]);
            return response()->json(['message'=>'Quantity update success'],200);
        }
        return response()->json(['message'=>'Product does not exists'],404);
    }

    public function getproducts()
    {
        return response()->json(productmodel::get(), 200);
    }


    public function missing()
    {
        $db=DB::table('stocks')->select('products.ProductName', Db::raw('count(*) as missing'))
            ->join('products', 'products.Id', '=', 'stocks.ProductId')
            ->join('projects', 'projects.Id', '=', 'stocks.ProjectId')
            ->where('stocks.CompartmentId','=', null)
            ->where('stocks.ProductId','!=', null)
            ->where('stocks.ProjectId','!=', null)
            ->groupBy('products.ProductName')->get();
        if($db->count()>0)
            return response()->json($db, 200);
        return response( "",204);


    }

    public function shelf(Request $req)
    {
        $proid = $req->input('productid');
        $level = $req->input('level');
        $shelf = $req->input('shelf');
        $row = $req->input('row');
    try {
        $sql = DB::table('stocks')
            ->whereNotNull(['ProductId', 'ProjectId'])
            ->whereNull('CompartmentId')
            ->where('ProductId', '=', $proid)
            ->first();
    }
    catch (QueryException $ex)
    {
        return response("Ellenőrizze a paramétereket.", 400);
    }
        if ($sql != null) {
            $id = $sql->Id;

            DB::statement("
    UPDATE stocks
    SET CompartmentId = (
        SELECT Id FROM compartments
        WHERE Level = ? AND Shelf = ? AND compartments.Row = ?
    )
    WHERE Id = ?
", [$level, $shelf, $row, $id]);


            return response("Sikeres frisítés.",202);
        }

        else {

            try {
                DB::statement("insert into stocks(ProductId, CompartmentId)
    values($proid,(select Id from compartments where Level= ? AND Shelf= ? AND compartments.Row= ? ))", [$level, $shelf, $row]);
return response("Sikeres adatbeszúrás", 201);
            }
            catch (QueryException $ex)
            {
                if($ex->getCode()=='23000')
                    return  response("Foglalt már a rekesz",409);
                else
                    return  response("Hiba a lekérdezés során",500);

            }
        }
    }


    public function used()
    {
        $results = DB::table('compartments')
            ->select('Shelf', 'compartments.Row', 'compartments.Level')
            ->join('stocks', 'stocks.CompartmentId', '=', 'compartments.Id')
            ->whereNotNull('CompartmentId')
            ->get();

        return response()->json($results, 200);
    }

    public function reserve(Request $req)
    {
        $prodid=$req->input('productid');
        $projid=$req->input('projectid');

        DB::table('projects')->where('Id',$projid)->update(['State'=>2]);

        $sql=DB::table('stocks')->whereNull('ProjectId')
            ->whereNotNull('CompartmentId')
            ->whereNotNull('ProductId')
            ->where('ProductId',$prodid);

        if($sql->get()->count()>0)
        {
            $count=DB::table('stocks')->where('Id', $sql->first()->Id)
                ->update([
                    'ProjectId'=>$projid
                ]);
            if($count>0)
                return response()->json([],202);
            return response()->json([],205);

        }
        else
        {
            $inscount=DB::table('stocks')->insert(
                [
                    'ProductId' => $prodid,
                    'ProjectId' => $projid
                ]
            );

            if($inscount>0)
                return response()->json([],201);
            return response()->json([],205);
        }

    }

    public function pricecalculationpreview(Request $req)
    {
        $project=$req->input('projectid');

        $count=DB::table('stocks')->where('ProjectId', $project)
            ->whereNull('CompartmentId');

        if($count->get()->count()>0)
        {
            $suc=DB::table('projects')->where('Id', $project)->update(['State' => 3]);
            if($suc>0)
                return response()->json("",202);
        }
        else
        {
            $suc=DB::table('projects')->where('Id', $project)->update(['State' => 4]);
            if($suc>0)
                return response()->json("",200);
        }


    }


    public function pricecalculation(Request $req)
    {
        $project=$req->input('projectid');

        $sql=DB::table('stocks')
            ->join('products', 'products.Id', '=', 'stocks.ProductId')
            ->join('projects', 'projects.Id', '=', 'stocks.ProjectId')
            ->select(DB::raw('SUM(WorkTime * projects.Price) + SUM(products.Price) as projectprice'))
            ->where('projects.Id', '=', $project)
            ->first();

        if (!$sql) {
            return response()->json(['error' => 'Internal Server Error'], 500);
        }
        return response()->json($sql, 200);
    }

    public function closeproject(Request $req)
    {
        $project=$req->input('projectid');
        $state=$req->input('projectstate');

        DB::table('stocks')->where('ProjectId', $project)
            ->update(['ProjectId' => null]);

        DB::table('stocks')->whereNull('CompartmentId')
            ->whereNull('ProjectId')->delete();

        $res=DB::table('projects')->where('Id', $project)->update(['state'=>$state]);
        return response()->json("Sikeres állapot frissítés");

    }

    public function listorderproduct()
    {
        $sql=DB::table('products')
            ->leftJoin('stocks', 'products.Id', '=', 'stocks.ProductId')
            ->select('products.ProductName', DB::raw('0 as db'))
            ->whereNull('stocks.ProductId')
            ->orWhereNull('stocks.CompartmentId')
            ->distinct()
            ->get();

        return response()->json($sql, 200);
    }

    public function listmissingproduct()
    {
        $sql=DB::table('stocks')
            ->join('products', 'products.Id', '=', 'stocks.ProductId')
            ->select('ProductName', DB::raw('COUNT(*) as hiány'))
            ->whereNull('CompartmentId')
            ->groupBy('ProductName')
            ->get();

        return response()->json($sql, 200);
    }

}
