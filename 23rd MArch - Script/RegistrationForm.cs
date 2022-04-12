
 <!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>

    <meta charset="utf-8" />
    <title></title>
    <link rel="stylesheet" href="RegistrationFormStyle.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.3.0/font/bootstrap-icons.css" />

    <script src="RegistrationFormScript.js"></script>

</head>



<body>
    <form name="myform" action="Index.html" onsubmit="return validate()">
        <fieldset>
            <h1>Registration Form</h1>
            <label>Enter your Fisrt name</label><br>
            <input type="text" name="fname">
            <p id="fnameloc" style="color:red"></p>

            <label>Enter your Last Name</label><br>
            <input type="text" name="lname"><br>
            <p id="lnameloc" style="color:red"></p>

            <label>Enter your Email</label><br>
            <input type="text" name="email">
            <p id="emailloc" style="color:red"></p>
            <p>
                <label>Enter your Password</label><br>
                <input type="password" name="psw" id="password" />
            <p id="passwordloc" style="color:red"></p>
            <i class="bi bi-eye-slash" id="togglePassword"></i>
            </p>
            <label>Enter your Age </label><br>
            <input type="text" name="age" style="width:10%"><br>
            <p id="ageloc" style="color:red"></p>
            <input type="submit" value="submit">
        </fieldset>
    </form>

</body>
<script>
    const togglePassword = document.querySelector("#togglePassword");
    const password = document.querySelector("#password");

    togglePassword.addEventListener("click", function () {
        console.log(3);
        const type = password.getAttribute("type") === "password" ? "text" : "password";
        password.setAttribute("type", type);
        this.classList.toggle("bi-eye");
    });
</script>


</html>
 