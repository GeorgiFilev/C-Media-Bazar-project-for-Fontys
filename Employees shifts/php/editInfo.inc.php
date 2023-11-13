<?php
session_start();
    require 'db.php';
try{
    $conn ->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    $sql = "UPDATE employees SET fname = :fname, lname = :lname, age = :age, gender = :gender, email = :email, phone = :phone, bplace = :bplace, bday = :bday, city = :city, zip = :zip, address = :adress, snumber = :snumber, nationality = :nationality, wshifts = :wshifts, password = :pass, CheckPassword = '1' WHERE id LIKE :id";    
    
    $stmt = $conn->prepare($sql);

    $stmt ->bindParam(':fname',$a);
    $stmt ->bindParam(':lname',$b);
    $stmt ->bindParam(':age',$c);
    $stmt ->bindParam(':gender',$n);
    $stmt ->bindParam(':email',$d);
    $stmt ->bindParam(':phone',$e);
    $stmt ->bindParam(':bplace',$f);
    $stmt ->bindParam(':bday',$g);
    $stmt ->bindParam(':city',$h);
    $stmt ->bindParam(':zip',$i);
    $stmt ->bindParam(':adress',$j);
    $stmt ->bindParam(':snumber',$k);
    $stmt ->bindParam(':nationality',$l);
    $stmt ->bindParam(':wshifts',$m);
    $stmt ->bindParam(':pass',$password);

    $stmt ->bindParam(':id',$id);

    $password = $_POST['password'];
    $a=$_POST['firstName'];
    $b=$_POST['lastName'];
    $c=$_POST['age'];
    $d=$_POST['email'];
    $e=$_POST['phone'];
    $f=$_POST['birthdayPlace'];
    $g=$_POST['birthday'];
    $h=$_POST['city'];
    $i=$_POST['zipcode'];
    $j=$_POST['adress'];
    $k=$_POST['socialNumber'];
    $l=$_POST['nationality'];
    $m=$_POST['prefferedShifts'];
    $n=$_POST['gender'];
    $id = $_SESSION['id'];

    $stmt ->execute();

   $_SESSION['firstName'] = $a;
   $_SESSION['lastName'] = $b;
   $_SESSION['age'] = $c;
   $_SESSION['gender']= $n;
   $_SESSION['email'] =$d;
   $_SESSION['phone'] =$e;
   $_SESSION['placeOfBirth'] = $f;
   $_SESSION['birthday'] = $g;
   $_SESSION['city'] = $h;
   $_SESSION['zip'] = $i;
   $_SESSION['adress'] =$j;
   $_SESSION['snumber'] =$k;
   $_SESSION['nationality'] =$l;
   $_SESSION['wshifts'] = $m;
   $_SESSION['password'] =$password;

   echo "successful";
}
catch(PDOExeption $e)
{
    echo "Error" . $e->getMessage();
}
  $conn = null;
   ?>














