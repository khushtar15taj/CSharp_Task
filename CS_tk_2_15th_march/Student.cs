using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_tk_2_15th_march
{
    public class Student
    {
        int[] marks = { 10, 20, 30, 40 , 50 };
        public void MarksCalculator()
        {
            Console.WriteLine("Total" + (marks.Sum()));
            double tot = marks.Sum();
            double percentage = (tot / 250) * 100;
            Console.WriteLine(percentage +"%");
        }

    }
}
