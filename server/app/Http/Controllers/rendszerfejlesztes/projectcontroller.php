<?php

namespace App\Http\Controllers\rendszerfejlesztes;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;

use App\Models\projectmodel;
use Illuminate\Support\Facades\DB;
class projectcontroller extends Controller
{
    public function getall(Request $req)
    {
        return response()->json(projectmodel::get(),200);
    }

    public function create(Request $req)
    {
        projectmodel::create($req->all());
        return response()->json('Record created', 201);
    }

    public function setdateandprice(Request $req, $proname)
    {
        $price=$req->input('newprice');
        $work=$req->input('workhour');

        $sql=DB::table('projects')->where('ProjectName',$proname);
        if($sql->first()!=null)
        {
            $sql->update(['WorkTime'=>$work, 'Price' => $price]);
            return response()->json('Record update successful.', 200);
        }

        return response()->json('Record does not found', 404);

    }

    public function getid(Request $req, $projectname)
    {
        $project = projectmodel::where('ProjectName', $projectname)->first(); // Az első találat
        if ($project) {
            return response()->json(['id' => $project->Id]);
        } else {
            return response()->json(['error' => 'Projekt nem található']);
        }
    }

    public function updatestate(Request $req, $name)
    {
        $affect=DB::table('projects')->where('ProjectName', $name)->update(['state'=>$req->input('state')]);
        if($affect>0)
            return response()->json("Sikeresen frissítettem az állapotot",200);
        else
            return response()->json("Nincs ilyen nevű project.", 404);

    }

    public function inprogress(Request $req, $proid)
    {
        $sql=DB::table('projects')->where("Id", $proid)->update(['state'=>5]);

        if(!$sql)
            return response("internal server error",500);

        if($sql>0)
            return response()->json("",202);
        return response()->json("", 204);
    }

    public function getcomp(Request $req, $projectid)
    {
        $sql=DB::table('stocks')->join('compartments', 'stocks.CompartmentId', '=', 'compartments.Id')
            ->join('products', 'stocks.ProductId', '=', 'products.Id')
            ->select('products.ProductName as ProductName', 'compartments.Shelf as Shelf', 'compartments.Row as Row', 'compartments.Level as Level')
            ->where('stocks.ProjectId', $projectid);
        if(!$sql)
            return response("Internal server error", 500);
        if($sql->count()>0)
            return response()->json($sql->get(),200);
        return response()->json("",204);
    }
}
