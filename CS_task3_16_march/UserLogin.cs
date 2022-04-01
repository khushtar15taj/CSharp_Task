using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CS_task3_16_march
{
    public class UserLogin
    {
       
        public void ValidateEmail(string email)
        {

            Regex rgx = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*
                                 @(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
            bool valid = rgx.IsMatch(email);
            if (!valid)
            {
                Console.WriteLine("Please Enter Valid Email Address");
            }
            else
            {
                Console.WriteLine(" Your Email is Verified");
            }
        }
        public void ValidatePin(int pin)
        {
           
            Regex rgx = new Regex(@"(^[0-9]{4}$)");
            bool valid = rgx.IsMatch(pin.ToString());
            if(!valid)
            {
                Console.WriteLine("Please Enter Valid pin with 4 digits");
            }
            else
            {
                Console.WriteLine(" Your Pin is Verified");
            }
        }

        public void ValidatePhone(double phno)
        {
            
            Regex rgx = new Regex(@"(^[0-9]{10}$)");
            bool valid = rgx.IsMatch(phno.ToString());
            if (!valid)
            {
                Console.WriteLine("Please Enter Valid Phone Number ");
            }
            else
            {
                Console.WriteLine(" Your PhoneNumber is Verified");
            }
        }

    }
}
