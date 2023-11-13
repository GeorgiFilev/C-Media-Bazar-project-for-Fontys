<?php
session_start();

    if(isset($_POST))
    {
        try{
        require 'db.php';

        $username = $_POST['uname'];
        $password = $_POST['pass'];

        
            $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
            $sql="SELECT * FROM employees WHERE email = :username ";
            $stmt = $conn->prepare($sql);
            $stmt -> bindParam(":username",$username); // username = username _POST

            $stmt -> execute();
            $user = $stmt -> fetchAll();
        }
        catch(Exception $e){
            echo 'Caught exception: ',  $e->getMessage(), "\n";
        }
            $count = 0;
           
        foreach($user as $row)
        {
            if( $row['lname'] == $password && $row['CheckPassword'] == 0 )
            {
                $_SESSION['id']= $row['id'];
                $_SESSION['firstName']= $row['fname'];
                $_SESSION['lastName']= $row['lname'];
                $_SESSION['age']= $row['age'];
                $_SESSION['gender']= $row['gender'];
                $_SESSION['email']= $row['email'];
                $_SESSION['phone']= $row['phone'];
                $_SESSION['placeOfBirth']= $row['bplace'];
                $_SESSION['birthday']= $row['bday'];
                $_SESSION['city']= $row['city'];
                $_SESSION['zip']= $row['zip'];
                $_SESSION['adress']= $row['address'];
                $_SESSION['snumber']= $row['snumber'];
                $_SESSION['nationality']= $row['nationality'];
                $_SESSION['hdate']= $row['hdate'];
                $_SESSION['wdays']= $row['wdays'];
                $_SESSION['wshifts']= $row['wshifts'];
                $_SESSION['password']="";
                $_SESSION['companyRole']= $row['companyRole'];


                $sli ="SELECT * FROM shifts where id = :id";
                $s = $conn ->prepare($sli);
                $s -> bindParam(':id',$_SESSION['id']);
                $s -> execute();
                $result = $s -> fetchAll(\PDO::FETCH_ASSOC);
                
                

                $_SESSION['shifts']= $result;
                
            
               $count = 1;
            }
            else if($row['password'] == $password)
            {
                $_SESSION['id']= $row['id'];
                $_SESSION['firstName']= $row['fname'];
                $_SESSION['lastName']= $row['lname'];
                $_SESSION['age']= $row['age'];
                $_SESSION['gender']= $row['gender'];
                $_SESSION['email']= $row['email'];
                $_SESSION['phone']= $row['phone'];
                $_SESSION['placeOfBirth']= $row['bplace'];
                $_SESSION['birthday']= $row['bday'];
                $_SESSION['city']= $row['city'];
                $_SESSION['zip']= $row['zip'];
                $_SESSION['adress']= $row['address'];
                $_SESSION['snumber']= $row['snumber'];
                $_SESSION['nationality']= $row['nationality'];
                $_SESSION['hdate']= $row['hdate'];
                $_SESSION['wdays']= $row['wdays'];
                $_SESSION['wshifts']= $row['wshifts'];
                $_SESSION['password']=$row['password'];
                $_SESSION['companyRole']= $row['companyRole'];

                $sli ="SELECT * FROM shifts where id = :id";
                $s = $conn ->prepare($sli);
                $s -> bindParam(':id',$_SESSION['id']);
                $s -> execute();
                $result = $s -> fetchAll(\PDO::FETCH_ASSOC);
                
                

                $_SESSION['shifts']= $result;
                
                $count = 2;
            }       
       
        }

        if($count == 0)
        {
            header("Location: ../index.html");
            exit();
        }
        else if($count ==1)
        {
            header("Location: ../editInfo.php");
            exit();
        }
        else if($count ==2)
        {
            header("Location: ../home.php");
            exit();
        }

        
    }
    else{
        header("Location: ../index.html");
        exit();
    }