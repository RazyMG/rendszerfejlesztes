<?php
	include "connect.php";
	include "execute.php";
?>

<?php
			$vfelv="SELECT * FROM products ";
			$res=ask($vfelv); 
			
			while($i=$res->fetch_array())
			{
			echo $i[0].";".$i[1].";".$i[2].";".$i[3].";".$i[4]."\n";
			}
			?>