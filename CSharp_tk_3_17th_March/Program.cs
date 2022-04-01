using System;

namespace CSharp_tk_3_17th_March
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Project shows  Membership Functionality And  Arithematic Functionality\n");
            Console.WriteLine("Press M For Membership and A for Arithematic");
            char c = Console.ReadLine()[0];
            Function func = new Function();
            if (c == 'a' || c == 'A') func.ArithematicFunction();
            else if (c == 'm' || c == 'M') func.MembershipFunction();
            else Console.WriteLine("Please Enter valid Functionality");
            
        }
    }
}
