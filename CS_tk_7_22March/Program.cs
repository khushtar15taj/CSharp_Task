using System;

namespace CS_tk_7_22March
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Pastries pastries = new Pastries();
            pastries.DessertWriter();
            pastries.DesserReader();
            Console.Read();
        }
    }
}
