using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleActivity
{
    
    public class Customer
    {
        public int CustID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public DateTime DoB { get; set; }
        public string EmailID { get; set; }
        public string ContactNo { get; set; }
        public string city { get; set; }

    }
    public class product
    {
        public int ProdID { get; set; } 
        public string ProdName { get; set; }
        public int price { get; set; }
        public DateTime ManufacturedDate { get; set; }
        public DateTime ExpiryDate { get; set; }


    }

    
}
