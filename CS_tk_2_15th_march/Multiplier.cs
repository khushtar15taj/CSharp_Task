using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_tk_2_15th_march
{
    public class Multiplier
    {
        public int number;
        public Multiplier( int x)
        {
            number = x;
        }
        public void Multiplication()
        {
            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine(number + "*" + i + " = " + number * i);
            }
        }

    }
}
