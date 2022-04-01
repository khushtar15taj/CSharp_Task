using System;

namespace CS_tk_2_15th_march
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NameAge display = new NameAge();
            display.NameAgeDisplayer();

            Multiplier multiple = new Multiplier(6);
            multiple.Multiplication();

            Package packs = new Package('A');
            packs.ChannelPackage();

            Student student = new Student();
            student.MarksCalculator();



        }
    }
}
