using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12th_April_2022
{
    public class CRUD_Query
    {
        string connectionString = "data source = SQL201901.softura.com; database = Kustartaj_TempDB; user id =Kustartaj; password=Kustartaj@123";
        List<Enrollment> students = new List<Enrollment>()
        {
            new Enrollment() { studentID = 1, name = "Sania", standard = 10 },
            new Enrollment() { studentID = 2, name = "Salman", standard = 8 },
            new Enrollment() { studentID = 3, name = "Saba", standard = 5 },
            new Enrollment() { studentID = 4, name = "Safia", standard = 3 }
        };
        public void InsertQuery()
        {
            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Enrollment(studentID,name,standard)" +
                        "values(@studentID,@name,@standard)");
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.Add("@studentID", SqlDbType.Int);
                    cmd.Parameters.Add("@name", SqlDbType.VarChar);
                    cmd.Parameters.Add("@standard", SqlDbType.Int);
                    foreach (Enrollment enrollment in students)
                    {
                        cmd.Parameters[0].Value = enrollment.studentID;
                        cmd.Parameters[1].Value = enrollment.name;
                        cmd.Parameters[2].Value = enrollment.standard;

                        cmd.ExecuteNonQuery();
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

        public void UpdateQuery(int studentID, string name, int standard)
        {
            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE Enrollment SET studentID = @studentID, name  = @name , standard = @standard Where studentID = @studentID", connection);
                    command.Parameters.AddWithValue("@studentID", studentID);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@standard", standard);
                    command.ExecuteNonQuery();
                    connection.Close();
                    Console.WriteLine("Row Updated");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }

        public void DeleteQuery(string table, string ColumnName, int studentID)
        {
            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM " + table + " WHERE " + ColumnName + " = " + studentID, connection))
                    {
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
