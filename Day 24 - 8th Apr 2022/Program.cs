using System;

namespace Day_24___8th_Apr_2022
{
    public class Program
    {
        static void Main(string[] args)
        {
            int legs = Convert.ToInt32(Console.ReadLine()); ;
            int eyes = Convert.ToInt32(Console.ReadLine()); ;
            int goats, ducks;
            int total = eyes / 2;
            goats  = (legs - eyes) / 2;
            ducks = total - goats;

            Console.WriteLine("the Number of goats and ducks are as follows respectively {0}, {1}" ,goats,ducks);
        }
    }
}
