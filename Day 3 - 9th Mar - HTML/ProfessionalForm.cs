< !DOCTYPE html >
 < html >
 < head >
 
     < meta charset = "utf-8" />
  
      < link rel = "stylesheet" href = "https://www.w3schools.com/w3css/4/w3.css" >
     

         < title > Form in HTML </ title >
        </ head >
        < style >
            input[type = text], select
{
width: 30 %;
padding: 12px 20px;
margin: 8px 0;
display: inline - block;
border: 1px solid #ccc;
        border - radius: 4px;
    box - sizing: border - box;
}
input[type = submit] {
width: 30 %;
    background - color: #4CAF50;
        color: white;
padding: 14px 20px;
margin: 8px 0;
border: none;
    border - radius: 4px;
cursor: pointer;
}

input[type = submit]:hover
{
    background - color: #45a049;
        }
div
{
    border - radius: 5px;
    background - color: #f2f2f2;
        padding: 20px;
}



</ style >
< body >
    < h2 > Registration form </ h2 >
   
       < div >
   
           < form >
   
               < fieldset >
   
                   < legend > </ legend >
   
                   < label > Fisrt name </ label >< br >
      
                      < input type = "text" name = "name" >< br >
         
                         < label > Last Name </ label >< br >
            
                            < input type = "text" name = "email" >< br >
               
                               < label > Mothers''Name </ label >< br >
                  
                                  < input type = "text" name = "pass" >< br >
                     
                                     < label > confirm your Father's Name'</label><br>
                <input type="text" name="pass"><br>
                <br><label>gender</label><br>
                <input type="radio" id="gender" name="gender" value="male" />Male  <br>
                <input type="radio" id="gender" name="gender" value="female" />Female <br />
                <input type="radio" id="gender" name="gender" value="others" />others <br />
                <br>Address:< br >
                < textarea ></ textarea >< br >
                < input type = "submit" value = "sign-up" >
   
               </ fieldset >
   
           </ form >
   
       </ div >
   
       < p > Manual Instruction PDF<a href="D:\Kendo UI Grid Export.pdf">example</a>.</p>
</body>
</html>  