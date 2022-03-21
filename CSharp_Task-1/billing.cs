using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_1
{
    public class billing
    {
        public void EBConsumption()
        {
            Console.WriteLine("Please Enter the number of units");
            int units = Convert.ToInt32(Console.ReadLine());

            if (units >= 501)
            {
                units = (units - 500) * 7 + 1600;
            }
            if (units >= 351 && units <= 500)
            {
                units = (units - 350) * 5 + 850;
            }
            if (units >= 201 && units <= 350)
            {
                units = (units - 200) * 3 + 400;
            }
            if (units <= 200)
            {
                units = units * 2;
            }
            Console.WriteLine("your Electricity bill is {0}" , units);

        }
    }
}
        
    

