<?php
function ask($operation)
{
	global $db;
	$eredmeny=$db->query($operation)
	or die($db->error);
	return $eredmeny;
}

function upl($operation)
{
	global $db;
	$eredmeny=$db->query($operation)
	or die($db->error);
	return $eredmeny;
}
?>