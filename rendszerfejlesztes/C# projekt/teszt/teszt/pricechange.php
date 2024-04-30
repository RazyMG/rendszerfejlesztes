<?php
	include "connect.php";
	include "execute.php";
?>

<?php
			$vfelv="UPDATE products SET Price={$_POST['Price']} WHERE Id={$_POST['Id']}";
			upl($vfelv);
			
			?>