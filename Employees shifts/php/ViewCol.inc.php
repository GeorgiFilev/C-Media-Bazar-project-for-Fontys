<?php
    session_start();
    require 'db.php';
    $conn ->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    $sql = "SELECT fname, lname, phone FROM employees WHERE employmentRequest = 0;";
    $stmt = $conn->prepare($sql);
    $stmt->execute();
    $result = $stmt -> fetchAll(\PDO::FETCH_NUM);
    echo json_encode($result);
?>