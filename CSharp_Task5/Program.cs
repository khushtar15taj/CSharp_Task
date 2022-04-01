using System;

namespace CSharp_Task5
{
    
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Persons p1 = new Persons(25, "khushtar");
            Persons p2 = new Persons();
            p2.Age = 24;
            p2.Name = "taj";

            SalesEmployee sales = new SalesEmployee(1, "JohnSales", "Male", 5 ,25000);
            sales.ShowSalesEmployee();

            MarketingEmployee market = new MarketingEmployee(2, "JohnMarket", "Male", 9, 780000);
            market.ShowSalesEmployee();

            ProductionEmployee Production = new ProductionEmployee(3, "JohnProduction", "male", 10, 9479576998);
            Production.ShowSalesEmployee();

            Console.ReadLine(); 
        }
    }
}
