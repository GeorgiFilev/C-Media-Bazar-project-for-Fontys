
    <?php
session_start();
  
        require 'db.php';

        $username = $_SESSION['email'];

        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
            $sql="SELECT * FROM employees WHERE email = :username ";
            $stmt = $conn->prepare($sql);
            $stmt -> bindParam(":username",$username); // username = username _POST

            $stmt -> execute();
            $user = $stmt -> fetchAll(\PDO::FETCH_NUM);

            $sli ="SELECT day, week, shift FROM shifts where id = :id";
            $s = $conn ->prepare($sli);
            $s -> bindParam(':id',$_SESSION['id']);
            $s -> execute();
            $result = $s -> fetchAll(\PDO::FETCH_NUM);
            $shifts = $result;

            $info = array(); 

            foreach($user as $cell)
            {
                for ($i=0; $i < 17; $i++) { 
                    array_push($info,$cell[$i]);
                }
               
            }
            array_push($info,$shifts);
     //$data['result'] = $info;
     echo json_encode($info);
           
          ?>