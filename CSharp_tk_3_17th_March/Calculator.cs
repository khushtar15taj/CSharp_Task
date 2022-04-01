using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_tk_3_17th_March
{
    public class Calculator : Arithematic

    {
        public override void Addition(int num1, int num2)
        {
            Console.WriteLine("Addition is {0}", (num1 + num2));
        }

        public override void Division(decimal num1, decimal num2)
        {
            if (num2 != 0)
            {
               
                Console.WriteLine("Division is {0}", (Decimal.Divide(num1, num1)));
            }
            else
                Console.WriteLine("Number 2 Should not be zero");
        }

        public override void Multiplication(int num1, int num2)
        {
            Console.WriteLine("Multiplication is {0}", (num1 * num2));
        }

        public override void Subtraction(int num1, int num2)
        {
            Console.WriteLine("Subtraction is {0}", (num1 - num2));
        }
    }
}
