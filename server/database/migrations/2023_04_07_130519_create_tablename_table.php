<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;
use Illuminate\Support\Facades\DB;

return new class extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::connection('mysql')->create('users', function (Blueprint $table) {
            $table->increments('id')->unsigned();
            $table->string('username')->unique()->nullable(false);
            $table->enum('type', [1,2,3,4])->nullable(false);
            $table->string('Password')->nullable(false);
        });

        Schema::connection('mysql')->create('stocks', function (Blueprint $table){
            $table->increments('Id')->unsigned()->autoInclement();
            $table->integer('ProductId')->unsigned()->nullable();
            $table->integer('CompartmentId')->unsigned()->nullable();
            $table->integer('ProjectId')->unsigned()->nullable();
        });

        Schema::connection('mysql')->create('compartments', function (Blueprint $table){
            $table->increments('Id')->unsigned()->autoInclement();
            $table->boolean('isReserved')->default(false)->nullable(false);
            $table->enum('Shelf', ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J'])->nullable(false);
            $table->enum('Row', [1,2,3,4,5])->nullable(false);
            $table->enum('Level', [1,2,3,4,5,6])->nullable(false);
        });

        Schema::connection('mysql')->create('customers', function(Blueprint $table){
            $table->increments('Id')->unsigned()->autoInclement();
            $table->string('FirstName', 45)->nullable(false);
            $table->string('LastName', 45)->nullable(false);
            $table->string('City',45)->nullable(false);
            $table->integer('Zipcode')->unsigned()->nullable(false);
            $table->string('Address', 60)->nullable(false);
        });

        Schema::connection('mysql')->create('projects', function (Blueprint $table)
        {
            $table->increments('Id')->unsigned()->autoIncrement();
            $table->string('ProjectName')->unique()->nullable(false);
            $table->integer('CustomerId')->unsigned()->nullable(false);
            $table->integer('state')->unsigned()->nullable(false);
            $table->string('Place')->nullable(false);
            $table->string('Description')->nullable();
            $table->integer('WorkTime')->nullable(false);
            $table->integer('Price')->nullable(false);
        });

        Schema::connection('mysql')->create('products', function (Blueprint $table)
        {
            $table->increments('Id')->unsigned()->autoIncrement()->nullable(false);
            $table->string('ProductName',40)->nullable(false)->unique();
            $table->integer('Quantity')->nullable(false)->unsigned()->default(0);
            $table->integer('Price')->unsigned()->nullable(false)->default(1000);
            $table->integer('SumReserved')->unsigned()->nullable(false)->default(0);
            $table->integer('SumAvailable')->unsigned()->nullable(false)->default(0);
        });

        Schema::connection('mysql')->table('stocks', function (Blueprint $table)
        {
            $table->foreign('ProductId')->references('Id')->on('products');
            $table->foreign('CompartmentId')->references('Id')->on('compartments');
            $table->foreign('ProjectId')->references('Id')->on('projects');
        });

        Schema::connection('mysql')->table('projects', function (Blueprint $table)
        {
            $table->foreign('CustomerId')->references('Id')->on('customers');
        });

        DB::connection('mysql')->table('compartments')->insert([
            ['Shelf' => 'A', 	'Row' => 1, 	'Level' => 1],['Shelf' => 'A', 	'Row' => 1, 	'Level' => 2],['Shelf' => 'A', 	'Row' => 1, 	'Level' => 3],
            ['Shelf' => 'A', 	'Row' => 1, 	'Level' => 4],['Shelf' => 'A', 	'Row' => 1, 	'Level' => 5],['Shelf' => 'A', 	'Row' => 1, 	'Level' => 6],
            ['Shelf' => 'A', 	'Row' => 2, 	'Level' => 1],['Shelf' => 'A', 	'Row' => 2, 	'Level' => 2],['Shelf' => 'A', 	'Row' => 2, 	'Level' => 3],
            ['Shelf' => 'A', 	'Row' => 2, 	'Level' => 4],['Shelf' => 'A', 	'Row' => 2, 	'Level' => 5],['Shelf' => 'A', 	'Row' => 2, 	'Level' => 6],
            ['Shelf' => 'A', 	'Row' => 3, 	'Level' => 1],['Shelf' => 'A', 	'Row' => 3, 	'Level' => 2],['Shelf' => 'A', 	'Row' => 3, 	'Level' => 3],
            ['Shelf' => 'A', 	'Row' => 3, 	'Level' => 4],['Shelf' => 'A', 	'Row' => 3, 	'Level' => 5],['Shelf' => 'A', 	'Row' => 3, 	'Level' => 6],
            ['Shelf' => 'A', 	'Row' => 4, 	'Level' => 1],['Shelf' => 'A', 	'Row' => 4, 	'Level' => 2],['Shelf' => 'A', 	'Row' => 4, 	'Level' => 3],
            ['Shelf' => 'A', 	'Row' => 4, 	'Level' => 4],['Shelf' => 'A', 	'Row' => 4, 	'Level' => 5],['Shelf' => 'A', 	'Row' => 4, 	'Level' => 6],
            ['Shelf' => 'A', 	'Row' => 5, 	'Level' => 1],['Shelf' => 'A', 	'Row' => 5, 	'Level' => 2],['Shelf' => 'A', 	'Row' => 5, 	'Level' => 3],
            ['Shelf' => 'A', 	'Row' => 5, 	'Level' => 4],['Shelf' => 'A', 	'Row' => 5, 	'Level' => 5],['Shelf' => 'A', 	'Row' => 5, 	'Level' => 6],
            ['Shelf' => 'B', 	'Row' => 1, 	'Level' => 1],['Shelf' => 'B', 	'Row' => 1, 	'Level' => 2],['Shelf' => 'B', 	'Row' => 1, 	'Level' => 3],
            ['Shelf' => 'B', 	'Row' => 1, 	'Level' => 4],['Shelf' => 'B', 	'Row' => 1, 	'Level' => 5],['Shelf' => 'B', 	'Row' => 1, 	'Level' => 6],
            ['Shelf' => 'B', 	'Row' => 2, 	'Level' => 1],['Shelf' => 'B', 	'Row' => 2, 	'Level' => 2],['Shelf' => 'B', 	'Row' => 2, 	'Level' => 3],
            ['Shelf' => 'B', 	'Row' => 2, 	'Level' => 4],['Shelf' => 'B', 	'Row' => 2, 	'Level' => 5],['Shelf' => 'B', 	'Row' => 2, 	'Level' => 6],
            ['Shelf' => 'B', 	'Row' => 3, 	'Level' => 1],['Shelf' => 'B', 	'Row' => 3, 	'Level' => 2],['Shelf' => 'B', 	'Row' => 3, 	'Level' => 3],
            ['Shelf' => 'B', 	'Row' => 3, 	'Level' => 4],['Shelf' => 'B', 	'Row' => 3, 	'Level' => 5],['Shelf' => 'B', 	'Row' => 3, 	'Level' => 6],
            ['Shelf' => 'B', 	'Row' => 4, 	'Level' => 1],['Shelf' => 'B', 	'Row' => 4, 	'Level' => 2],['Shelf' => 'B', 	'Row' => 4, 	'Level' => 3],
            ['Shelf' => 'B', 	'Row' => 4, 	'Level' => 4],['Shelf' => 'B', 	'Row' => 4, 	'Level' => 5],['Shelf' => 'B', 	'Row' => 4, 	'Level' => 6],
            ['Shelf' => 'B', 	'Row' => 5, 	'Level' => 1],['Shelf' => 'B', 	'Row' => 5, 	'Level' => 2],['Shelf' => 'B', 	'Row' => 5, 	'Level' => 3],
            ['Shelf' => 'B', 	'Row' => 5, 	'Level' => 4],['Shelf' => 'B', 	'Row' => 5, 	'Level' => 5],['Shelf' => 'B', 	'Row' => 5, 	'Level' => 6],
            ['Shelf' => 'C', 	'Row' => 1, 	'Level' => 1],['Shelf' => 'C', 	'Row' => 1, 	'Level' => 2],['Shelf' => 'C', 	'Row' => 1, 	'Level' => 3],
            ['Shelf' => 'C', 	'Row' => 1, 	'Level' => 4],['Shelf' => 'C', 	'Row' => 1, 	'Level' => 5],['Shelf' => 'C', 	'Row' => 1, 	'Level' => 6],
            ['Shelf' => 'C', 	'Row' => 2, 	'Level' => 1],['Shelf' => 'C', 	'Row' => 2, 	'Level' => 2],['Shelf' => 'C', 	'Row' => 2, 	'Level' => 3],
            ['Shelf' => 'C', 	'Row' => 2, 	'Level' => 4],['Shelf' => 'C', 	'Row' => 2, 	'Level' => 5],['Shelf' => 'C', 	'Row' => 2, 	'Level' => 6],
            ['Shelf' => 'C', 	'Row' => 3, 	'Level' => 1],['Shelf' => 'C', 	'Row' => 3, 	'Level' => 2],['Shelf' => 'C', 	'Row' => 3, 	'Level' => 3],
            ['Shelf' => 'C', 	'Row' => 3, 	'Level' => 4],['Shelf' => 'C', 	'Row' => 3, 	'Level' => 5],['Shelf' => 'C', 	'Row' => 3, 	'Level' => 6],
            ['Shelf' => 'C', 	'Row' => 4, 	'Level' => 1],['Shelf' => 'C', 	'Row' => 4, 	'Level' => 2],['Shelf' => 'C', 	'Row' => 4, 	'Level' => 3],
            ['Shelf' => 'C', 	'Row' => 4, 	'Level' => 4],['Shelf' => 'C', 	'Row' => 4, 	'Level' => 5],['Shelf' => 'C', 	'Row' => 4, 	'Level' => 6],
            ['Shelf' => 'C', 	'Row' => 5, 	'Level' => 1],['Shelf' => 'C', 	'Row' => 5, 	'Level' => 2],['Shelf' => 'C', 	'Row' => 5, 	'Level' => 3],
            ['Shelf' => 'C', 	'Row' => 5, 	'Level' => 4],['Shelf' => 'C', 	'Row' => 5, 	'Level' => 5],['Shelf' => 'C', 	'Row' => 5, 	'Level' => 6],
            ['Shelf' => 'D', 	'Row' => 1, 	'Level' => 1],['Shelf' => 'D', 	'Row' => 1, 	'Level' => 2],['Shelf' => 'D', 	'Row' => 1, 	'Level' => 3],
            ['Shelf' => 'D', 	'Row' => 1, 	'Level' => 4],['Shelf' => 'D', 	'Row' => 1, 	'Level' => 5],['Shelf' => 'D', 	'Row' => 1, 	'Level' => 6],
            ['Shelf' => 'D', 	'Row' => 2, 	'Level' => 1],['Shelf' => 'D', 	'Row' => 2, 	'Level' => 2],['Shelf' => 'D', 	'Row' => 2, 	'Level' => 3],
            ['Shelf' => 'D', 	'Row' => 2, 	'Level' => 4],['Shelf' => 'D', 	'Row' => 2, 	'Level' => 5],['Shelf' => 'D', 	'Row' => 2, 	'Level' => 6],
            ['Shelf' => 'D', 	'Row' => 3, 	'Level' => 1],['Shelf' => 'D', 	'Row' => 3, 	'Level' => 2],['Shelf' => 'D', 	'Row' => 3, 	'Level' => 3],
            ['Shelf' => 'D', 	'Row' => 3, 	'Level' => 4],['Shelf' => 'D', 	'Row' => 3, 	'Level' => 5],['Shelf' => 'D', 	'Row' => 3, 	'Level' => 6],
            ['Shelf' => 'D', 	'Row' => 4, 	'Level' => 1],['Shelf' => 'D', 	'Row' => 4, 	'Level' => 2],['Shelf' => 'D', 	'Row' => 4, 	'Level' => 3],
            ['Shelf' => 'D', 	'Row' => 4, 	'Level' => 4],['Shelf' => 'D', 	'Row' => 4, 	'Level' => 5],['Shelf' => 'D', 	'Row' => 4, 	'Level' => 6],
            ['Shelf' => 'D', 	'Row' => 5, 	'Level' => 1],['Shelf' => 'D', 	'Row' => 5, 	'Level' => 2],['Shelf' => 'D', 	'Row' => 5, 	'Level' => 3],
            ['Shelf' => 'D', 	'Row' => 5, 	'Level' => 4],['Shelf' => 'D', 	'Row' => 5, 	'Level' => 5],['Shelf' => 'D', 	'Row' => 5, 	'Level' => 6],
            ['Shelf' => 'E', 	'Row' => 1, 	'Level' => 1],['Shelf' => 'E', 	'Row' => 1, 	'Level' => 2],['Shelf' => 'E', 	'Row' => 1, 	'Level' => 3],
            ['Shelf' => 'E', 	'Row' => 1, 	'Level' => 4],['Shelf' => 'E', 	'Row' => 1, 	'Level' => 5],['Shelf' => 'E', 	'Row' => 1, 	'Level' => 6],
            ['Shelf' => 'E', 	'Row' => 2, 	'Level' => 1],['Shelf' => 'E', 	'Row' => 2, 	'Level' => 2],['Shelf' => 'E', 	'Row' => 2, 	'Level' => 3],
            ['Shelf' => 'E', 	'Row' => 2, 	'Level' => 4],['Shelf' => 'E', 	'Row' => 2, 	'Level' => 5],['Shelf' => 'E', 	'Row' => 2, 	'Level' => 6],
            ['Shelf' => 'E', 	'Row' => 3, 	'Level' => 1],['Shelf' => 'E', 	'Row' => 3, 	'Level' => 2],['Shelf' => 'E', 	'Row' => 3, 	'Level' => 3],
            ['Shelf' => 'E', 	'Row' => 3, 	'Level' => 4],['Shelf' => 'E', 	'Row' => 3, 	'Level' => 5],['Shelf' => 'E', 	'Row' => 3, 	'Level' => 6],
            ['Shelf' => 'E', 	'Row' => 4, 	'Level' => 1],['Shelf' => 'E', 	'Row' => 4, 	'Level' => 2],['Shelf' => 'E', 	'Row' => 4, 	'Level' => 3],
            ['Shelf' => 'E', 	'Row' => 4, 	'Level' => 4],['Shelf' => 'E', 	'Row' => 4, 	'Level' => 5],['Shelf' => 'E', 	'Row' => 4, 	'Level' => 6],
            ['Shelf' => 'E', 	'Row' => 5, 	'Level' => 1],['Shelf' => 'E', 	'Row' => 5, 	'Level' => 2],['Shelf' => 'E', 	'Row' => 5, 	'Level' => 3],
            ['Shelf' => 'E', 	'Row' => 5, 	'Level' => 4],['Shelf' => 'E', 	'Row' => 5, 	'Level' => 5],['Shelf' => 'E', 	'Row' => 5, 	'Level' => 6],
            ['Shelf' => 'F', 	'Row' => 1, 	'Level' => 1],['Shelf' => 'F', 	'Row' => 1, 	'Level' => 2],['Shelf' => 'F', 	'Row' => 1, 	'Level' => 3],
            ['Shelf' => 'F', 	'Row' => 1, 	'Level' => 4],['Shelf' => 'F', 	'Row' => 1, 	'Level' => 5],['Shelf' => 'F', 	'Row' => 1, 	'Level' => 6],
            ['Shelf' => 'F', 	'Row' => 2, 	'Level' => 1],['Shelf' => 'F', 	'Row' => 2, 	'Level' => 2],['Shelf' => 'F', 	'Row' => 2, 	'Level' => 3],
            ['Shelf' => 'F', 	'Row' => 2, 	'Level' => 4],['Shelf' => 'F', 	'Row' => 2, 	'Level' => 5],['Shelf' => 'F', 	'Row' => 2, 	'Level' => 6],
            ['Shelf' => 'F', 	'Row' => 3, 	'Level' => 1],['Shelf' => 'F', 	'Row' => 3, 	'Level' => 2],['Shelf' => 'F', 	'Row' => 3, 	'Level' => 3],
            ['Shelf' => 'F', 	'Row' => 3, 	'Level' => 4],['Shelf' => 'F', 	'Row' => 3, 	'Level' => 5],['Shelf' => 'F', 	'Row' => 3, 	'Level' => 6],
            ['Shelf' => 'F', 	'Row' => 4, 	'Level' => 1],['Shelf' => 'F', 	'Row' => 4, 	'Level' => 2],['Shelf' => 'F', 	'Row' => 4, 	'Level' => 3],
            ['Shelf' => 'F', 	'Row' => 4, 	'Level' => 4],['Shelf' => 'F', 	'Row' => 4, 	'Level' => 5],['Shelf' => 'F', 	'Row' => 4, 	'Level' => 6],
            ['Shelf' => 'F', 	'Row' => 5, 	'Level' => 1],['Shelf' => 'F', 	'Row' => 5, 	'Level' => 2],['Shelf' => 'F', 	'Row' => 5, 	'Level' => 3],
            ['Shelf' => 'F', 	'Row' => 5, 	'Level' => 4],['Shelf' => 'F', 	'Row' => 5, 	'Level' => 5],['Shelf' => 'F', 	'Row' => 5, 	'Level' => 6],
            ['Shelf' => 'G', 	'Row' => 1, 	'Level' => 1],['Shelf' => 'G', 	'Row' => 1, 	'Level' => 2],['Shelf' => 'G', 	'Row' => 1, 	'Level' => 3],
            ['Shelf' => 'G', 	'Row' => 1, 	'Level' => 4],['Shelf' => 'G', 	'Row' => 1, 	'Level' => 5],['Shelf' => 'G', 	'Row' => 1, 	'Level' => 6],
            ['Shelf' => 'G', 	'Row' => 2, 	'Level' => 1],['Shelf' => 'G', 	'Row' => 2, 	'Level' => 2],['Shelf' => 'G', 	'Row' => 2, 	'Level' => 3],
            ['Shelf' => 'G', 	'Row' => 2, 	'Level' => 4],['Shelf' => 'G', 	'Row' => 2, 	'Level' => 5],['Shelf' => 'G', 	'Row' => 2, 	'Level' => 6],
            ['Shelf' => 'G', 	'Row' => 3, 	'Level' => 1],['Shelf' => 'G', 	'Row' => 3, 	'Level' => 2],['Shelf' => 'G', 	'Row' => 3, 	'Level' => 3],
            ['Shelf' => 'G', 	'Row' => 3, 	'Level' => 4],['Shelf' => 'G', 	'Row' => 3, 	'Level' => 5],['Shelf' => 'G', 	'Row' => 3, 	'Level' => 6],
            ['Shelf' => 'G', 	'Row' => 4, 	'Level' => 1],['Shelf' => 'G', 	'Row' => 4, 	'Level' => 2],['Shelf' => 'G', 	'Row' => 4, 	'Level' => 3],
            ['Shelf' => 'G', 	'Row' => 4, 	'Level' => 4],['Shelf' => 'G', 	'Row' => 4, 	'Level' => 5],['Shelf' => 'G', 	'Row' => 4, 	'Level' => 6],
            ['Shelf' => 'G', 	'Row' => 5, 	'Level' => 1],['Shelf' => 'G', 	'Row' => 5, 	'Level' => 2],['Shelf' => 'G', 	'Row' => 5, 	'Level' => 3],
            ['Shelf' => 'G', 	'Row' => 5, 	'Level' => 4],['Shelf' => 'G', 	'Row' => 5, 	'Level' => 5],['Shelf' => 'G', 	'Row' => 5, 	'Level' => 6],
            ['Shelf' => 'H', 	'Row' => 1, 	'Level' => 1],['Shelf' => 'H', 	'Row' => 1, 	'Level' => 2],['Shelf' => 'H', 	'Row' => 1, 	'Level' => 3],
            ['Shelf' => 'H', 	'Row' => 1, 	'Level' => 4],['Shelf' => 'H', 	'Row' => 1, 	'Level' => 5],['Shelf' => 'H', 	'Row' => 1, 	'Level' => 6],
            ['Shelf' => 'H', 	'Row' => 2, 	'Level' => 1],['Shelf' => 'H', 	'Row' => 2, 	'Level' => 2],['Shelf' => 'H', 	'Row' => 2, 	'Level' => 3],
            ['Shelf' => 'H', 	'Row' => 2, 	'Level' => 4],['Shelf' => 'H', 	'Row' => 2, 	'Level' => 5],['Shelf' => 'H', 	'Row' => 2, 	'Level' => 6],
            ['Shelf' => 'H', 	'Row' => 3, 	'Level' => 1],['Shelf' => 'H', 	'Row' => 3, 	'Level' => 2],['Shelf' => 'H', 	'Row' => 3, 	'Level' => 3],
            ['Shelf' => 'H', 	'Row' => 3, 	'Level' => 4],['Shelf' => 'H', 	'Row' => 3, 	'Level' => 5],['Shelf' => 'H', 	'Row' => 3, 	'Level' => 6],
            ['Shelf' => 'H', 	'Row' => 4, 	'Level' => 1],['Shelf' => 'H', 	'Row' => 4, 	'Level' => 2],['Shelf' => 'H', 	'Row' => 4, 	'Level' => 3],
            ['Shelf' => 'H', 	'Row' => 4, 	'Level' => 4],['Shelf' => 'H', 	'Row' => 4, 	'Level' => 5],['Shelf' => 'H', 	'Row' => 4, 	'Level' => 6],
            ['Shelf' => 'H', 	'Row' => 5, 	'Level' => 1],['Shelf' => 'H', 	'Row' => 5, 	'Level' => 2],['Shelf' => 'H', 	'Row' => 5, 	'Level' => 3],
            ['Shelf' => 'H', 	'Row' => 5, 	'Level' => 4],['Shelf' => 'H', 	'Row' => 5, 	'Level' => 5],['Shelf' => 'H', 	'Row' => 5, 	'Level' => 6],
            ['Shelf' => 'I', 	'Row' => 1, 	'Level' => 1],['Shelf' => 'I', 	'Row' => 1, 	'Level' => 2],['Shelf' => 'I', 	'Row' => 1, 	'Level' => 3],
            ['Shelf' => 'I', 	'Row' => 1, 	'Level' => 4],['Shelf' => 'I', 	'Row' => 1, 	'Level' => 5],['Shelf' => 'I', 	'Row' => 1, 	'Level' => 6],
            ['Shelf' => 'I', 	'Row' => 2, 	'Level' => 1],['Shelf' => 'I', 	'Row' => 2, 	'Level' => 2],['Shelf' => 'I', 	'Row' => 2, 	'Level' => 3],
            ['Shelf' => 'I', 	'Row' => 2, 	'Level' => 4],['Shelf' => 'I', 	'Row' => 2, 	'Level' => 5],['Shelf' => 'I', 	'Row' => 2, 	'Level' => 6],
            ['Shelf' => 'I', 	'Row' => 3, 	'Level' => 1],['Shelf' => 'I', 	'Row' => 3, 	'Level' => 2],['Shelf' => 'I', 	'Row' => 3, 	'Level' => 3],
            ['Shelf' => 'I', 	'Row' => 3, 	'Level' => 4],['Shelf' => 'I', 	'Row' => 3, 	'Level' => 5],['Shelf' => 'I', 	'Row' => 3, 	'Level' => 6],
            ['Shelf' => 'I', 	'Row' => 4, 	'Level' => 1],['Shelf' => 'I', 	'Row' => 4, 	'Level' => 2],['Shelf' => 'I', 	'Row' => 4, 	'Level' => 3],
            ['Shelf' => 'I', 	'Row' => 4, 	'Level' => 4],['Shelf' => 'I', 	'Row' => 4, 	'Level' => 5],['Shelf' => 'I', 	'Row' => 4, 	'Level' => 6],
            ['Shelf' => 'I', 	'Row' => 5, 	'Level' => 1],['Shelf' => 'I', 	'Row' => 5, 	'Level' => 2],['Shelf' => 'I', 	'Row' => 5, 	'Level' => 3],
            ['Shelf' => 'I', 	'Row' => 5, 	'Level' => 4],['Shelf' => 'I', 	'Row' => 5, 	'Level' => 5],['Shelf' => 'I', 	'Row' => 5, 	'Level' => 6],
            ['Shelf' => 'J', 	'Row' => 1, 	'Level' => 1],['Shelf' => 'J', 	'Row' => 1, 	'Level' => 2],['Shelf' => 'J', 	'Row' => 1, 	'Level' => 3],
            ['Shelf' => 'J', 	'Row' => 1, 	'Level' => 4],['Shelf' => 'J', 	'Row' => 1, 	'Level' => 5],['Shelf' => 'J', 	'Row' => 1, 	'Level' => 6],
            ['Shelf' => 'J', 	'Row' => 2, 	'Level' => 1],['Shelf' => 'J', 	'Row' => 2, 	'Level' => 2],['Shelf' => 'J', 	'Row' => 2, 	'Level' => 3],
            ['Shelf' => 'J', 	'Row' => 2, 	'Level' => 4],['Shelf' => 'J', 	'Row' => 2, 	'Level' => 5],['Shelf' => 'J', 	'Row' => 2, 	'Level' => 6],
            ['Shelf' => 'J', 	'Row' => 3, 	'Level' => 1],['Shelf' => 'J', 	'Row' => 3, 	'Level' => 2],['Shelf' => 'J', 	'Row' => 3, 	'Level' => 3],
            ['Shelf' => 'J', 	'Row' => 3, 	'Level' => 4],['Shelf' => 'J', 	'Row' => 3, 	'Level' => 5],['Shelf' => 'J', 	'Row' => 3, 	'Level' => 6],
            ['Shelf' => 'J', 	'Row' => 4, 	'Level' => 1],['Shelf' => 'J', 	'Row' => 4, 	'Level' => 2],['Shelf' => 'J', 	'Row' => 4, 	'Level' => 3],
            ['Shelf' => 'J', 	'Row' => 4, 	'Level' => 4],['Shelf' => 'J', 	'Row' => 4, 	'Level' => 5],['Shelf' => 'J', 	'Row' => 4, 	'Level' => 6],
            ['Shelf' => 'J', 	'Row' => 5, 	'Level' => 1],['Shelf' => 'J', 	'Row' => 5, 	'Level' => 2],['Shelf' => 'J', 	'Row' => 5, 	'Level' => 3],
            ['Shelf' => 'J', 	'Row' => 5, 	'Level' => 4],['Shelf' => 'J', 	'Row' => 5, 	'Level' => 5],['Shelf' => 'J', 	'Row' => 5, 	'Level' => 6]

        ]);
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::connection('mysql')->table('projects', function (Blueprint $table)
        {
            $table->dropForeign('projects_customerid_');
            $table->dropForeign('UserId');
        });

        Schema::connection('mysql')->table('stocks', function (Blueprint $table)
        {
            $table->dropForeign('ProductId');
            $table->dropForeign('UserId');
            $table->dropForeign('CompartmentId');
            $table->dropForeign('ProjectId');
        });

        Schema::connection('mysql')->dropIfExists('users');
        Schema::connection('mysql')->dropIfExists('projects');
        Schema::connection('mysql')->dropIfExists('stocks');
        Schema::connection('mysql')->dropIfExists('products');
        Schema::connection('mysql')->dropIfExists('customers');
        Schema::connection('mysql')->dropIfExists('compartments');
    }
};
