<?php

namespace App\Http\Controllers\rendszerfejlesztes;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;


use App\Models\usermodel;

class usercontroller extends Controller
{
    public function user(): \Illuminate\Http\JsonResponse
    {
        return response()->json(usermodel::get(), 200);
    }

    public  function userid($id): \Illuminate\Http\JsonResponse
    {
        return response()->json(usermodel::find($id),200);
    }

    public function adduser(Request $req)
    {
        $username=$req->input('username');
        $password=$req->input('password');
        $type=$req->input('type');

        try {
            $count=DB::table('users')->insert(['username'=>$username, 'type'=>$type, 'Password'=>$password]);
        }
        catch (\Illuminate\Database\QueryException $ex)
        {
            if($ex->errorInfo[1]==1062)
                return response("Már létezik ilyen nevű felhasználó.",409);
            return response("Hiba tortent a lekerdezes soran.",500);
        }
        if($count>0)
            return response("A felhasznalot hozzaadtam az adatbázishoz.",201);


    }

    public  function login(Request $req)
    {
        $usr=$req->input('username');
        $pwd=$req->input('password');

        $rec=DB::table('users')->where('username', $usr)->where('Password', $pwd)->select('type')->first();

        if(!empty($rec))
            return response()->json($rec,200);
        else
            return response()->json(['type' => 0],404);
    }

    public function update(Request $req, usermodel $user)
    {
        $user->update($req->all());
        return response()->json($user,200);
    }

    public function delusr(Request $req, $name)
    {
        $user=usermodel::where('username', $name)->first();
        if($user)
        {
            $user->delete();
            return response()->json("A felhasznalo torolve lett",200);
        }
        else
            return response()->json("Nincs ilyen felhasznalo.",404);
    }
}
