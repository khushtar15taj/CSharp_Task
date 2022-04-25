using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleActivity
{
   
    public class CRUD_Action
    {
        string connectionString = "data source = SQL201901.softura.com; database = Kustartaj_TempDB; user id =Kustartaj; password=Kustartaj@123";

        public void ValidateCustID(int CustID)
        {
            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                try
                {
                    connection.Open();
                    //Showing the customer about product list if the passed customer id exist
                   
                     SqlDataReader dr = CheckCustomerID(connection,CustID);
                    if (dr.HasRows)
                    {
                        CustomerExistMethod(dr, connection, CustID);

                    }
                   
                    else
                    {
                        dr.Close();
                        NewCustomerRegistration(connection);
                         
                    }

                connection.Close();
                }
                catch (Exception ex)
                
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        public void ShowDetailsByCustID(int CustID)
        {
            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand Billing_Command = new SqlCommand("sp_Billing_CustID", connection))

                    {
                        Console.WriteLine(" History of your Purchase \n");
                        Billing_Command.CommandType = CommandType.StoredProcedure;
                        Billing_Command.Parameters.AddWithValue("@CustID", CustID);
                        SqlDataReader drBill = Billing_Command.ExecuteReader();
                        while (drBill.Read())
                        {
                            Console.WriteLine("Product Name " + drBill[0] + " " + "TotalAmount" + drBill[1] + " " + "Quantity" + " " + drBill[2] + " " + "Customername" + " " + drBill[3]);
                        }
                        Console.ReadLine();
                    }
                    connection.Close();
                    Console.WriteLine("Enter Purchase date");
                    DateTime purchaseDate = DateTime.Parse(Console.ReadLine());

                    ShowDetailsByDate(purchaseDate);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                connection.Close();
            }

        }

        public int CurrentCustID(SqlConnection connection)
        {
            int CustIDCurrent = 0;
            using (SqlCommand Billing_Command = new SqlCommand("sp_NewCustID", connection))

            {
                
                Console.WriteLine("Thank you for Registaring with us Hope you shop more /n");
                Billing_Command.CommandType = CommandType.StoredProcedure;
                SqlDataReader drCustID = Billing_Command.ExecuteReader();

                while (drCustID.Read()) // Soultion for b.ShowProducts()
                {
                    CustIDCurrent = (int)drCustID[0];
                }
                Console.ReadLine();
                return CustIDCurrent;
            }
           
        }

        public void ShowDetailsByDate(DateTime Date)
        {
            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand Billing_Command = new SqlCommand("sp_Billing_Date", connection))

                    {
                        Billing_Command.CommandType = CommandType.StoredProcedure;
                        Billing_Command.Parameters.AddWithValue("@Date", Date);
                        SqlDataReader drBill = Billing_Command.ExecuteReader();
                        while (drBill.Read())
                        {
                            Console.WriteLine("Product Name " + drBill[0] + " " + "TotalAmount" + " " + drBill[1] + " " + "Quantity" + " " + drBill[2] + " " + "Customername" + " " + drBill[3]);
                        }
                    }
                    Console.ReadLine();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        public SqlDataReader CheckCustomerID(SqlConnection connection, int CustID)
        {
           
            SqlCommand cmd = new SqlCommand("select c.name, p.ProdID,p.ProdName,p.price,p.ManufacturedDate,p.ExpiryDate from product p, Customer c where c.CustID = @CustID ", connection);
            cmd.Parameters.AddWithValue("@CustID", CustID);
            SqlDataReader dr = cmd.ExecuteReader();
            
            return dr;

        }

        public void NewCustomerRegistration(SqlConnection connection)
        {

            Console.WriteLine("Please Create Your Account");
            Console.WriteLine("Enter Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Gender");
            string Gender = Console.ReadLine();
            Console.WriteLine("Enter Date Of Birth");
            DateTime DoB = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Contact No");
            string ContactNo = Console.ReadLine();
            Console.WriteLine("Enter EmailAddress");
            string EmailID = Console.ReadLine();
            Console.WriteLine("Enter city");
            string city = Console.ReadLine();

            SqlCommand Command_Insert = new SqlCommand("Insert into Customer(Name,Gender,DoB,ContactNo,EmailID,city)" +
            "values(@Name,@Gender,@DoB,@ContactNo,@EmailID,@city)");
            Command_Insert.CommandType = System.Data.CommandType.Text;
            Command_Insert.Connection = connection;
            Command_Insert.Parameters.AddWithValue("@Name", Name);
            Command_Insert.Parameters.AddWithValue("@Gender", Gender);
            Command_Insert.Parameters.AddWithValue("@DoB", DoB);
            Command_Insert.Parameters.AddWithValue("@ContactNo", ContactNo);
            Command_Insert.Parameters.AddWithValue("@EmailID", EmailID);
            Command_Insert.Parameters.AddWithValue("@city", city);
            Command_Insert.ExecuteNonQuery();

        }

        public void CustomerExistMethod(SqlDataReader dr,SqlConnection connection,int CustID)
        {
            int NameIteration = 0;
            while (dr.Read()) // Soultion for b.ShowProducts()
            {
                if (NameIteration == 0)
                {
                    Console.WriteLine("CustomerName : " + dr[0] + "\n");
                    Console.WriteLine("ProductID : " + dr[1] + " " + "Product Name : " + dr[2] + "  " + "price : " + dr[3] + " " + "Manufactured Date : " + dr[4] + " " + "Expiry Date : " + " " + dr[5]);
                    NameIteration = NameIteration + 1;
                }
                else
                {
                    Console.WriteLine("ProductID : " + dr[1] + " " + "Product Name : " + dr[2] + "  " + "price : " + dr[3] + " " + "Manufactured Date : " + dr[4] + " " + "Expiry Date : " + " " + dr[5]);
                }

            }//Ask them Which Product? And How many unit?
            Console.WriteLine("\nPlease enter Product ID of the product you want");
            int ProdID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Quantity of the Product");
            int Quantity = int.Parse(Console.ReadLine());

            //Inserting values inside purchase table according to the respected customer id
            using (SqlCommand command = new SqlCommand("sp_InsertPurchase", connection))
            {
                dr.Close();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@CustID", CustID));
                command.Parameters.Add(new SqlParameter("@ProdID", ProdID));
                command.Parameters.Add(new SqlParameter("@Quantity", Quantity));
                command.ExecuteNonQuery();
            }

            //Bill – Show the current purchase bill
            using (SqlCommand Billing_Command = new SqlCommand("sp_Billing", connection))

            {
                Billing_Command.CommandType = CommandType.StoredProcedure;
                Billing_Command.Parameters.AddWithValue("@CustID", CustID);
                SqlDataReader drBill = Billing_Command.ExecuteReader();
                while (drBill.Read())
                {
                    Console.WriteLine(" \nYour Total Amount is " + drBill[0]);
                }
            }

            Console.ReadLine();
            ShowDetailsByCustID(CustID);

        }

    }
}
