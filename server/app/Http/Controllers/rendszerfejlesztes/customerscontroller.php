<?php

namespace App\Http\Controllers\rendszerfejlesztes;

use App\Http\Controllers\Controller;
use App\Models\productmodel;
use Illuminate\Http\Request;

use App\Models\customersmodel;
use Illuminate\Support\Facades\DB;

class customerscontroller extends Controller
{
    public function create(Request $req)
    {
        $pro=customersmodel::create($req->all());
        return response()->json($pro,201);
    }

    public function getid(Request $req)
    {
        $firstname = $req->input('FirstName');
        $lastname = $req->input('LastName');
        $customer = DB::table('customers')->where('FirstName', $firstname)->where('LastName', $lastname)->value('Id');
        if(!$customer)
            return response()->json(['message'=>'Record not found'],404);
        return response()->json(['id'=>$customer],200);
    }

    public function getall()
    {
        return response()->json(customersmodel::all());
    }
}
