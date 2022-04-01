using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_tk_3_17th_March
{
    public  class Function
    {
        public void MembershipFunction()
        {
            Console.WriteLine(" Press 1 for Silver Membership Benifits \n Press 2 for Gold Membership Benifits \n " +
                    "Press 3 for Platinum Membership Benifits \n");
            int membershipKey = Convert.ToInt32(Console.ReadLine());
            Membership member = new Membership();
            if (membershipKey == 1) member.SilverMembership();
            if (membershipKey == 2) member.GoldMembership();
            if (membershipKey == 3) member.PlatinumMembership();
            if (membershipKey != 1 && membershipKey != 2 && membershipKey != 3)
                Console.WriteLine("Please enter valid Membership Key");
        }

        public void ArithematicFunction()
        {
            Console.WriteLine("Please Enter your numbers");
            Arithematic A;
            A = new Calculator();
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            A.Addition(number1, number2);
            A.Subtraction(number1, number2);
            A.Multiplication(number1, number2);
            A.Division(number1, number2);

        }
    }
}
