using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUD_Action ca = new CRUD_Action();
            Console.WriteLine("Please enter CustomerID");
            int custID = Convert.ToInt32(Console.ReadLine());
            ca.ValidateCustID(custID);
            
          
        }
    }
}
