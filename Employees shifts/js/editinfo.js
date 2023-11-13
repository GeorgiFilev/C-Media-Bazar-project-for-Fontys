window.onload = function(){
    let button = document.querySelector("#button");
    let password = document.querySelector("#password");

    button.addEventListener("click",clicking);
    function clicking(){
        if(password.value === "")
        {
            alert("password required !");
        }
        else{
            let data = new FormData();
            let xhr = new XMLHttpRequest();
          // let tableInputs = [... document.querySelector("#info").getElementsByTagName("tbody")[0].getElementsByTagName("tr")];

          /*  tableInputs.forEach(row =>
            {
                let inputField = row.getElementsByTagName("th")[1].getElementsByTagName("input");
                data.append(inputField.id ,inputField.value);
            
            }); */
            console.log(xhr.readyState);
            for (let index = 0; index < 30; index+=2) {
                const element = document.querySelector("#info").getElementsByTagName("th")[index+1].getElementsByTagName("input")[0];
                data.append(element.id ,element.value);
                console.log(element.getAttribute("id"), element.value);
            }
            console.log(data);
            let formData = [...data];
            formData.forEach(row => {
                console.log(row);
            });
            
      
            
            xhr.onreadystatechange = function(){
                if( this.readyState == 4 && this.status == 200)
                {
                     console.log(this.responseText);
                    if(this.responseText = "successful")
                    {               
                        alert("success!");         
                        document.location.href="home.php";
                    }
                    else {
                        alert(this.response);
                    }
                }
            };
            xhr.open("POST","php/editInfo.inc.php",true);
            xhr.send(data);
            return false;
        }
        
    }
}