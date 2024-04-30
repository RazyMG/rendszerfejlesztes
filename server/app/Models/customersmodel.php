<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class customersmodel extends Model
{
    use HasFactory;

    protected $table="customers";

    public $timestamps=false;

    protected $fillable=[
        'FirstName',
        'LastName',
        'City',
        'Zipcode',
        'Address',
        'phonenumber'
    ];
}
