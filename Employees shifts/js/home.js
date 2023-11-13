 window.onload = function(){
    let button = document.querySelector("#button");
    button.addEventListener("click", peek);
    button.style.color = "blue";
    let coleagues = document.querySelector('#coleagues');
    if(col() == false)coleagues.addEventListener('click',col());

    let tableInfo = document.querySelector("#info");
    let tableShifts = document.querySelector("#shifts");

    function peek() {
       // alert("take a look at your scedule");
     
       if(tableInfo.getElementsByTagName("tbody").length<2)
       {
        let data = new FormData();
        let xhr = new XMLHttpRequest();

        
        xhr.onreadystatechange = function()
        {
            if(this.readyState == 4 && this.status == 200)
            {
                //console.log(this.response);
                let info = JSON.parse(this.response);
                console.log(info);

                let infoBody = document.createElement("tbody");
                let infoRow = document.createElement("tr");
                
                info.forEach(cell => {  
                    if(typeof cell == "string" )
                    {
                        let infoCell = document.createElement("td");
                        infoCell.innerHTML = cell;
                        infoRow.appendChild(infoCell);
                    }
                    else{
                        let shiftBody = document.createElement("tbody");
                        cell.forEach(shift => {
                            let ShiftRow = document.createElement("tr");
                            shift.forEach(data => {
                                let ShiftColumn = document.createElement("td");
                                    
                                ShiftColumn.innerHTML=data;
                                ShiftRow.appendChild(ShiftColumn);
                            })
                            shiftBody.appendChild(ShiftRow);
                        })

                        tableShifts.appendChild(shiftBody);
                    }
                } );
                infoBody.appendChild(infoRow);
                tableInfo.appendChild(infoBody);
            }
        }
  
        xhr.open("GET","php/fillTable.php",true);
        xhr.send(data);
        return false;
        }
    }
}
function col(){
    let data = new FormData();
    let xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function(){
        if(this.readyState == 4 && this.status == 200)
        {
            let info = JSON.parse(this.response);
            console.log(info);
            let body = document.querySelector("#coleagues");
            for( i = 0; i < info.length; i++) {
                let div = document.createElement("div");    
                let name = document.createElement("name");
                name.innerHTML= info[i][0] +" ";
                div.appendChild(name);
                let familyname = document.createElement("familyname");
                familyname.innerHTML = info[i][1] + " ";
                div.appendChild(familyname);
                let phone = document.createElement("phone");
                phone.innerHTML = info[i][2] + "</br>";
                div.appendChild(phone);
                    body.appendChild(div);
            }  
        }

    }
    xhr.open("GET", "php/ViewCol.inc.php",true);
    xhr.send(data);
    return true;
}
