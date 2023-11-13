<?php session_start(); 
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
     <link rel="stylesheet" type="text/css" href="css/home.css"> 
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>

<nav class="navbar navbar-expand navbar-dark bg-dark">
      <a class="navbar-brand" href="#">Media Bazaar</a>
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExample02" aria-controls="navbarsExample02" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>

      <div class="collapse navbar-collapse" id="navbarsExample02">
        <ul class="navbar-nav mr-auto">
          <li class="nav-item active">
            <a class="nav-link" href="home.php">Shifts <span class="sr-only">(current)</span></a>
          </li>
          <li class="nav-item active">
            <a class="nav-link" href="editinfo.php">Edit Your Info <span class="sr-only">(current)</span></a>
          </li>
          <li class="nav-item active">
            <a class="nav-link" href="colleagues.php">View Colleagues <span class="sr-only">(current)</span></a>
          </li>  
          <li class="nav-item active">
            <a style="margin-left:700px;" class="nav-link">
            <?php
              include("php/db.php");
             
             
              $query = "SELECT fname,lname,companyRole FROM employees WHERE fname ='".$_SESSION['firstName']."' AND lname ='".$_SESSION['lastName']."' " ;
              $result = $conn -> prepare($query);
              $result->execute(
                  array(
                  'fname' => $_SESSION["firstName"],
                  'lname' => $_SESSION["lastName"]
              )
          );

              if($result -> rowCount() > 0)
              {
                  while($row = $result->fetch())
                  {
                    echo ("Welcome," ." ". $_SESSION['firstName'] ." ". $_SESSION['lastName'] ." (". $_SESSION['companyRole'].")");   
                  }
              }
           ?>
        <!-- // echo ("Welcome," ." ". $_SESSION['firstName'] ." ". $_SESSION['lastName']);         -->
   <span class="sr-only">(current)</span></a>
          </li>           
        </ul>
       
        <ul class="nav navbar-nav navbar-right">
        <?php 
      if (isset($_SESSION['id'])) 
          {
              echo "<form action=php/logout.inc.php method=post>
            <button class=btn btn-primary style =color:pink;font-weight:bold; type=submit name=logout-submit>Logout</button>
            </form>";
          } 
           if(!isset($_SESSION['id']))
          {
            header("Location: http://localhost/Employees shifts/index.html");
            exit();
          }    
        ?>    
          <!-- <li><a href="#contact">Log out</a></li> -->
        </ul>
       
      </div>
    </nav> 
    <br><br><br>
   
    <footer class="page-footer font-small teal pt-4">
        
        <img style="height: 300px; widht: 300px;" src="images/media.png" class="rounded mx-auto d-block" alt="...">
        <br><br><br>
        

        
      <h1 style="text-align:center;">Your current shifts</h1>
      <br><br><br> 
      <table class="table ">
  <thead class="thead-dark">
    <tr>
      
      <th scope="col">Week</th>
      <th scope="col">Day</th>
      <th scope="col">Shift</th>
      <th scope="col">Department</th>

    </tr>
  </thead>
  <tbody>
  <?php
                include("php/db.php");
                $query = "SELECT day, shift, week,companyRole FROM shifts WHERE fname = :fname AND lname = :lname ";
                $result = $conn -> prepare($query);
                $result->execute(
                    array(
                    'fname' => $_SESSION["firstName"],
                    'lname' => $_SESSION["lastName"]
                )
            );

                if($result -> rowCount() > 0)
                {
                    while($row = $result->fetch())
                    {
                        echo "</td><td>" .$row["week"] . "</td><td>". $row["day"] . "</td><td>". $row["shift"] ."</td><td>". $row["companyRole"] ."</td></tr>";
                    }
                }
             ?>
  </tbody>
</table>   
<div style="font-weight:bold;" class="footer-copyright text-center py-3">© 2020 Copyright
    <a style="font-weight:bold;"> Media Bazaar</a>
  </div>
  <!-- Copyright -->

</footer>
</body>
</html>