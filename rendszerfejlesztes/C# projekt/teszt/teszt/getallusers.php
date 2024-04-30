<?php
	include "connect.php";
	include "execute.php";
?>

<?php
			$vfelv="SELECT * FROM users ";
			$res=ask($vfelv); 
			
			while($i=$res->fetch_array())
			{
			echo $i[0].";".$i[1].";".$i[2].";".$i[3]."\n";
			}
			?>