using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_1
{
    public class Health
    {
        public void HealthStatus()
        {
            Console.WriteLine("Please Enter yes if you have travel history");
            string status = Console.ReadLine();

            if (status.ToLower() == "yes" || status.ToLower() == "no")
            {

                if (status.ToLower() == "yes")
                {
                    Console.WriteLine("Do you have temparature");
                    status = Console.ReadLine();

                    if (status.ToLower() == "yes")
                    {
                        Console.WriteLine("Do you have Cough or sneeze");
                        status = Console.ReadLine();

                        if (status.ToLower() == "yes")
                        {
                            Console.WriteLine("Go for Swab test");
                        }
                        else if (status.ToLower() == "no")
                        {
                            Console.WriteLine("Quarantine fever medicine");
                        }
                    }
                    else if (status.ToLower() == "no")
                    {
                        Console.WriteLine("Home Quarantine for 28 days");
                    }
                }

                else if (status.ToLower() == "no")
                {
                    Console.WriteLine("Safe from Covid19");
                }
            }
            else
            {
                Console.WriteLine("Please enter valid input with yes or no");
            }
        
        
        }
    }
}
