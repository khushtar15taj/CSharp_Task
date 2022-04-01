using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CS_tk_6_21March
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DessertFile df = new DessertFile();
            df.DessertWriter();
            df.DesserReader();

            Employee emp = new Employee();
            emp.Id = 1;
            emp.Name = "krish";
            emp.Age = 25;
            emp.Gender = "female";

            EmployeeFile efile = new EmployeeFile();
            efile.WriteToBinaryFile(emp);
            efile.Deserialize();
            Console.Read();

        }
    }
}
