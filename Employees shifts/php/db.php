<?php

$dbServername="studmysql01.fhict.local";
$dbUsername="dbi432557";
$dbPassword="vedsalta";
$dbName="dbi432557";
$dsn = 'mysql:host=' . $dbServername . ';dbname=' . $dbName;

$conn =new PDO($dsn,$dbUsername,$dbPassword);
if(!$conn)
{   
    die("Connection failed: ");
}
