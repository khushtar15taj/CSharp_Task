var login_attempts = 3;
function validate()
{
    var name = document.getElementById("name").value;
    var pass = document.getElementById("password").value;
    console.log(pass);
    if (!name && !pass)
    {
        return false;
    }
    else
    {

        if (name == "khushtar" && pass == "khushtar")
        {
            document.getElementById("name").value = "";
            document.getElementById("password").value = "";
            return true;

        }
        else
        {
            if (login_attempts == 0)
            {
                alert("No Login Attempts Available");
                console.log(8);
                document.getElementById("name").disabled = true;
                document.getElementById("password").disabled = true;
                document.getElementById("form1").disabled = true;
                document.getElementById('hide_id').style.cursor = 'none';
            }
            else
            {
                login_attempts = login_attempts - 1;
                alert("Login Failed Now Only " + login_attempts + " Login Attempts Available");
                if (login_attempts == 0)
                {
                    console.log(2);
                    document.getElementById("name").disabled = true;
                    document.getElementById("password").disabled = true;
                    document.getElementById("form1").disabled = true;
                    document.getElementById('hide_id').style.cursor = 'none';

                }
            }
        }

    }
    return false;

}