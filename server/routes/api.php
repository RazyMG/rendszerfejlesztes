<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

use App\Http\Controllers\rendszerfejlesztes;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "api" middleware group. Make something great!
|
*/

//Route::middleware('auth:sanctum')->get('/user', function (Request $request) {
//    return $request->user();
//});

Route::get('user',[rendszerfejlesztes\usercontroller::class, 'user']);
Route::get('user/{id}',[rendszerfejlesztes\usercontroller::class, 'userid']);
Route::post('user/login', [rendszerfejlesztes\usercontroller::class, 'login']);
Route::put('user/mod/{user}', [rendszerfejlesztes\usercontroller::class, 'update']);
Route::post('user/add',[rendszerfejlesztes\usercontroller::class, 'adduser']);
Route::delete('user/delete/{name}',[rendszerfejlesztes\usercontroller::class, 'delusr']);


Route::get('product',[rendszerfejlesztes\productcontroller::class, 'getproducts']);
Route::post('product/create', [rendszerfejlesztes\productcontroller::class, 'createproduct']);
Route::put('product/{ProductName}', [rendszerfejlesztes\productcontroller::class, 'modifyprice']);
Route::put('product/updatequantity/{name}', [rendszerfejlesztes\productcontroller::class, 'modquantity']);
Route::get('product/missing', [rendszerfejlesztes\productcontroller::class, 'listmissingproduct']);
Route::get('product/needmore', [rendszerfejlesztes\productcontroller::class, 'listorderproduct']);


Route::post('customer/create', [rendszerfejlesztes\customerscontroller::class, 'create']);
Route::post('customer/get', [rendszerfejlesztes\customerscontroller::class, 'getid']);
Route::get('customers/all', [rendszerfejlesztes\customerscontroller::class, 'getall']);


Route::get('project/all', [rendszerfejlesztes\projectcontroller::class, 'getall']);
Route::post('project/create', [rendszerfejlesztes\projectcontroller::class, 'create']);
Route::put('project/addworktimeandprice/{proname}', [rendszerfejlesztes\projectcontroller::class, 'setdateandprice']);
Route::get('project/getid/{projectname}', [rendszerfejlesztes\projectcontroller::class, 'getid']);
Route::put('project/updatestate/{name}',[rendszerfejlesztes\projectcontroller::class, 'updatestate'] );
Route::post('project/close',[rendszerfejlesztes\productcontroller::class, 'closeproject'] );
Route::put('project/inprogress/{proid}', [rendszerfejlesztes\projectcontroller::class, 'inprogress']);
Route::get('project/getshelf/{projectid}', [rendszerfejlesztes\projectcontroller::class, 'getcomp']);


Route::post('stock/add', [rendszerfejlesztes\productcontroller::class, 'shelf']);
Route::get('stock/used', [rendszerfejlesztes\productcontroller::class, 'used']);
Route::post('stock/reserve', [rendszerfejlesztes\productcontroller::class, 'reserve']);
Route::post('stock/pricepreset', [rendszerfejlesztes\productcontroller::class, 'pricecalculationpreview']);
Route::post('stock/pricecalculation', [rendszerfejlesztes\productcontroller::class, 'pricecalculation']);

