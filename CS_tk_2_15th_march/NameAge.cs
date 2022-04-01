using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_tk_2_15th_march
{
    public class NameAge
    {
        public void NameAgeDisplayer()
        {
            Console.WriteLine("Please Enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Name");
            string Name = Console.ReadLine();
            Console.WriteLine("\n");

            for (int i = 0; i < age; i++)
            {
                Console.WriteLine(Name);
            }
        }
    }
}
