<?php
	include "connect.php";
	include "execute.php";
?>

<?php
			$vfelv="INSERT INTO users (Username,Type,Password) VALUES ('{$_POST['Username']}', {$_POST['Type']},'{$_POST['Password']}');";
			upl($vfelv);
			
			?>