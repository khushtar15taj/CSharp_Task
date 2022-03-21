using System;

namespace CSharp_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Elctricity bill \n and 2 for Covid test \n");

            int Function = Convert.ToInt32(Console.ReadLine());
            
            if(Function == 1)
            {
                billing bill = new billing();
                bill.EBConsumption();

            }
            else if (Function == 2)
            {
                Health ht = new Health();
                ht.HealthStatus();
                
            }
            if(Function != 1 && Function != 2)
            {
                Console.WriteLine("Please enter valid Key");
            }
        }
    }
}
