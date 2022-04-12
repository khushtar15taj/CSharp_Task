using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Task_12th_April_2022
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            CRUD_Query cd = new CRUD_Query();
            cd.InsertQuery();
            cd.UpdateQuery(1, "Sameer", 6);
            cd.DeleteQuery("Enrollment", "studentID", 1);
            CRUD_StoredProcedure csd = new CRUD_StoredProcedure();
            csd.InsertSP_Query();
            csd.UpdateSP_Query(1, "Saif", 6);
            csd.DeleteSP_Query(1);
        }
    }
}
