using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12th_April_2022
{
    public class CRUD_StoredProcedure
    {
        string connectionString = "data source = SQL201901.softura.com; database = Kustartaj_TempDB; user id =Kustartaj; password=Kustartaj@123";

        public void InsertSP_Query()
        {
            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                DataTable dt = new DataTable();
               
                dt.Columns.Add(new DataColumn("studentID", typeof(int)));
                dt.Columns.Add(new DataColumn("name", typeof(string)));
                dt.Columns.Add(new DataColumn("standard", typeof(string)));

                dt.Rows.Add(1,"Sania", 10);
                dt.Rows.Add(2,"Salman",8);
                dt.Rows.Add(3, "Saba", 6);
                dt.Rows.Add(4, "Safia", 4);
               
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_InsertStudent",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@studentDetails" ,dt);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                    Console.WriteLine("Row Inserted");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }


        public void UpdateSP_Query(int studentID, string name, int standard)
        {
            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_updateStudent", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@studentID", studentID);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@standard", standard);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                    Console.WriteLine("Row Updated");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }


        public void DeleteSP_Query(int studentID)
        {
            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_deleteStudent", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@studentID", studentID);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                    Console.WriteLine("Row Deleted");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

    }
}
