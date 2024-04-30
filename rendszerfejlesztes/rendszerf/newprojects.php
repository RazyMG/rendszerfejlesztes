<?php
	include "connect.php";
	include "execute.php";
?>

<?php
			$vfelv="INSERT INTO users (CustomerId,UserId,State) VALUES ({$_POST['CustomerId']}, {$_POST['UserId']},{$_POST['State']});";
			upl($vfelv);
			
			?>