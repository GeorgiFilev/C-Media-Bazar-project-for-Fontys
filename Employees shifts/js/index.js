
window.onload = function () {
    let cantlog = document.querySelector("#cantlog");
    cantlog.addEventListener("click", oops);
    function oops(){
        alert("Contact your manager to get your account details.");
    }

    let button = document.querySelector("#btn");
    button.addEventListener("click", login);
    function login() {

        let user = document.querySelector("#u");
        let pass = document.querySelector("#p");
        console.log(user.value);
        if (user.value === "" || pass.value === "") {
            alert("Fulfil all the fields!");
        }
    }
};
