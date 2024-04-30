<?php
	include "connect.php";
	include "execute.php";
?>

<?php
			$vfelv="INSERT INTO users (FirstName,LastName,City,ZipCode,Address,PhoneNumber) VALUES ('{$_POST['FirstName']}','{$_POST['LastName']}','{$_POST['City']}',{$_POST['ZipCode']},'{$_POST['Address']}',{$_POST['PhoneNumber']});";
			upl($vfelv);
			
			?>