using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task5
{
    public class Employee
    {
        public int Id;
        public string Name;
        public string Gender;
        public int Experience;
        public double salary;
       
        public void ShowSalesEmployee()
        {
            Console.WriteLine("Employee ID: {0} \n Name: {1} \n Gender : {2} \n Experienece: {3}" +
                " \n salary :{4} \n ", Id, Name, Gender, Experience, salary);
        }
    }
    public class SalesEmployee : Employee
    {
        public SalesEmployee(int Id, string Name, string Gender , int Experience ,double salary) 
        {
            this.Id = Id;
            this.Name = Name;
            this.Gender = Gender;
            this.Experience = Experience;
            double bonus = (double)(20) / 100 * salary;
            this.salary = salary + bonus;
        }
      
    }
    public class MarketingEmployee : Employee
    {
        public MarketingEmployee(int Id, string Name, string Gender, int Experience, double salary) 
        {
            this.Id = Id;
            this.Name = Name;
            this.Gender = Gender;
            this.Experience = Experience;
            double bonus = (double)(20) / 100 * salary;
            this.salary = salary + bonus;

        }

    }
    public class ProductionEmployee : Employee
    {
        public ProductionEmployee(int Id, string Name, string Gender, int Experience, double salary) 
        {
            this.Id = Id;
            this.Name = Name;
            this.Gender = Gender;
            this.Experience = Experience;
            double bonus = (double)(10) / 100 * salary;
            this.salary = salary + bonus;

        }

    }

}

