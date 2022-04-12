function validate()
{
    var fname = document.myform.fname.value;
    var lname = document.myform.lname.value;
    var ages = document.myform.age.value;
    var emails = document.myform.email.value;
    var password = document.myform.psw.value;
    var validRegex = / ^[a - zA - Z0 - 9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
    var passwordPattern = / (?=.*\d)(?=.*[a - z])(?=.*[A - Z]).{ 8,}/;

    console.log(4);

    if (!isNaN(fname) || fname == "")
    {
        document.getElementById("fnameloc").innerHTML = "Enter valid first name";
        document.getElementById("togglePassword").style.top = "400px";
        return false;
    }
    else
    {
        document.getElementById("fnameloc").innerHTML = "";
    }
    if (!isNaN(lname) || lname == "")
    {
        document.getElementById("lnameloc").innerHTML = "Enter valid last name";
        document.getElementById("togglePassword").style.top = "400px";
        return false
    }
    else
    {
        document.getElementById("lnameloc").innerHTML = "";
    }
    if (emails == "" || !(emails.match(validRegex)))
    {
        document.getElementById("emailloc").innerHTML = "Enter valid Email";
        document.getElementById("togglePassword").style.top = "400px";
        return false;
    }
    else
    {
        document.getElementById("emailloc").innerHTML = "";
    }
    console.log(password);
    if (password == "" || !((String(password)).match(passwordPattern)))
    {
        document.getElementById("passwordloc").innerHTML = " Password Must contain at least one number and one uppercase and lowercase letter, and at least 8 or more characters";
        document.getElementById("togglePassword").style.top = "365px";
        return false;
    }
    else
    {
        document.getElementById("passwordloc").innerHTML = "";
    }

    if (isNaN(ages) || ages == "")
    {
        document.getElementById("ageloc").innerHTML = "Enter valid Age";
        document.getElementById("password").style.top = "465px";
        return false;
    }
    else
    {
        document.getElementById("ageloc").innerHTML = "";
    }

    return true;

}