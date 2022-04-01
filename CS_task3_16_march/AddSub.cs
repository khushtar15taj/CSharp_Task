using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_task3_16_march
{
    public class AddSub
    {
        public double Number1;
        public double Number2;
        public AddSub(double x, double y)
        {
            Number1 = x;
            Number2 = y;
        }


        public void AddSubtract()
        {
            Console.WriteLine("Addition is {0}", Number1 + Number2);
            Console.WriteLine("Subtraction is {0}", Number1 - Number2);
        }

    }
    public class MulDiv : AddSub
    {
        public MulDiv(double x, double y) : base(x, y)
        {
            Number1 = x;
            Number2 = y;
        }

        public void MulDivision()
        {
            if (Number2 != 0)
            {

                Console.WriteLine("Division is {0}", (double)Number1 / Number2);
            }
            else
                Console.WriteLine("Number 2 Should not be zero");

            Console.WriteLine("Multiplication is {0}", Number1 * Number2);

        }

    }
}
