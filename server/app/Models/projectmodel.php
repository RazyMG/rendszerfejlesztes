<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class projectmodel extends Model
{
    use HasFactory;

    protected $table="projects";

    public $timestamps=false;

    protected $fillable=[
        'ProjectName',
        'CustomerId',
        'UserId',
        'state',
        'Place',
        'Description',
        'WorkTime',
        'Price'
    ];
}
