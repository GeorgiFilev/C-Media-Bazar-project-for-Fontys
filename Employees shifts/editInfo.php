<?php 
    session_start();
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
    
    <title>Document</title>
</head>
<body>

<nav class="navbar navbar-expand navbar-dark bg-dark">
      <a class="navbar-brand" >Media Bazaar</a>
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExample02" aria-controls="navbarsExample02" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>

      <div class="collapse navbar-collapse" id="navbarsExample02">
        <ul class="navbar-nav mr-auto">
          <li class="nav-item active">
            <a class="nav-link" href="home.php">Shifts <span class="sr-only">(current)</span></a>
          </li>
          <li class="nav-item">
          <li class="nav-item active">
            <a class="nav-link" href="editinfo.php">Edit Your Info <span class="sr-only">(current)</span></a>
          </li>
          <li class="nav-item">
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
   <span class="sr-only">(current)</span></a>
          </li>                  
        </ul>
        <ul class="nav navbar-nav navbar-right">
        <?php 
      if (isset($_SESSION['id'])) 
          {
              echo "<form action=php/logout.inc.php method=post>
            <button class=btn btn-primary style=color:pink;font-weight:bold; type=submit name=logout-submit>Logout</button>
            </form>";
          } 
           if(!isset($_SESSION['id']))
          {
            header("Location: http://localhost/Employees shifts/index.html");
            exit();
          }    
        ?>    
        </ul>
        
      </div>
    </nav> 
    <br><br><br>
    <footer class="page-footer font-small teal pt-4">
    <h2 style="text-align:center;">Your Personal Details</h2>
    <br><br><br>
    <table class = "table table-hover table-light" id="info">
    
        <tbody>
            
            <tr>
                <th>First Name</th>
                <th><input class="form-control" id="firstName" type="text" value="<?php print_r($_SESSION['firstName']) ?>"></th>
            </tr>
            <tr>
                <th>Last name</th>
                <th><input class="form-control" type="text" id="lastName" value="<?php print_r($_SESSION['lastName']) ?>"></th>
            </tr>
            <tr>
                <th>Age</th>    
                <th><input class="form-control" type="text" id="age" value="<?php print_r($_SESSION['age']) ?>"></th>
            </tr>
            <tr>
                <th>Gender</th>
                <th><input class="form-control" type="text" id="gender" value="<?php print_r($_SESSION['gender']) ?>"></th>
            </tr>
            <tr>
                <th>E-mail</th>
                <th><input class="form-control" type="text" id="email" value="<?php print_r($_SESSION['email']) ?>"></th>
            </tr>
            <tr>
                <th>Phone</th>
                <th><input class="form-control" type="text" id="phone" value="<?php print_r($_SESSION['phone']) ?>"></th>
            </tr>
            <tr>
                <th>Birthday place</th>
                <th><input class="form-control" type="text" id="birthdayPlace" value="<?php print_r($_SESSION['placeOfBirth']) ?>"></th>
            </tr>
            <tr>
                 <th>Birthday</th>
                 <th><input class="form-control" type="text" id="birthday" value="<?php print_r($_SESSION['birthday']) ?>"></th>
            </tr>
            <tr>
                <th>City</th>
                <th><input class="form-control" type="text" id="city" value="<?php print_r($_SESSION['city']) ?>"></th>
            </tr>
            <tr>
                <th>Zipcode</th>
                <th><input class="form-control" type="text" id="zipcode" value="<?php print_r($_SESSION['zip']) ?>"></th>
            </tr>
            <tr>
                 <th>Adress</th>
                 <th><input class="form-control" type="text" id="adress" value="<?php print_r($_SESSION['adress']) ?>"></th>
            </tr>
            <tr>
                <th>Social number</th>
                <th><input class="form-control" type="text" id="socialNumber" value="<?php print_r($_SESSION['snumber']) ?>"></th>
            </tr>
            <tr>
                <th>Nationality</th>
                <th><input class="form-control" type="text" id="nationality" value="<?php print_r($_SESSION['nationality']) ?>"></th>
            </tr>
             <tr>
                <th>Preferred shifts</th>
                <th><input class="form-control" type="text" id="prefferedShifts" value="<?php print_r($_SESSION['wshifts']) ?>"></th>
             </tr>
             <tr>
                <th>Password</th>
                <th><input class="form-control" type="text" id="password" value="<?php print_r($_SESSION['password']) ?>"></th>
             </tr>
             
        </tbody>
    </table>
    <button class="btn btn-primary" id="button" type="button"> UPDATE </button>
    <br>

    <div style="font-weight:bold;" class="footer-copyright text-center py-3">© 2020 Copyright
    <a style="font-weight:bold;"> Media Bazaar</a>
  </div>
</body>
<script src="js/editinfo.js"></script>

</html>
