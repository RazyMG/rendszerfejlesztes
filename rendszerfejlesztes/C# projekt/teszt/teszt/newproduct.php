<?php
	include "connect.php";
	include "execute.php";
?>

<?php
			$vfelv="INSERT INTO users (ProductName,Quanity,SumReserved,Price) VALUES ('{$_POST['ProductName']}', {$_POST['Quanity']},{$_POST['SumReserved']},{$_POST['Price']});";
			upl($vfelv);
			
			?>