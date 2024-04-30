<?php
	include "connect.php";
	include "execute.php";
?>

<?php
			$vfelv="INSERT INTO stocks (ProductId,UserId,StockingId,Reserved,ProjectId,SpecialistId,Shelf,Row,Level) VALUES ({$_POST['ProductId']}, {$_POST['UserId']},{$_POST['StockingId']},{$_POST['ProjectId']},{$_POST['SpecialistId']},'{$_POST['Shelf']}',{$_POST['Row']},{$_POST['Level']});";
			upl($vfelv);
			
			?>