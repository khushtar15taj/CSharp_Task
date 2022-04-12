
  <!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>

    <meta charset="utf-8" />
    <title></title>
    <link rel="stylesheet" href="loginstyle.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.3.0/font/bootstrap-icons.css" />

    <script src="loginjs.js"></script>

</head>

<!--// action="Index.html"-->

<body>
    <form id="form1"  action="Index.html" onsubmit="return validate()">
        <fieldset>
            <h1>Registration Form</h1>


            <label>UserName</label><br>
            <input id="name" type="text" name="email">
            <p style="color:red"></p>
            <p>
                <label>Password</label><br>
                <input type="password" name="psw" id="password" />
            <p style="color:red"></p>
            <i class="bi bi-eye-slash" id="togglePassword"></i>
            </p>

            <input type="submit" value="Sign-up" id="hide_id">
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
