using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStore.Database
{
    class MainFormDB
    {
        private static string ConectionString = @"Server=localhost;database=HardwareStore;port=3306;user=root;password=3073";

        public MainFormDB()
        {

        }
        
        public int GetInvoiceId()
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"SELECT COUNT(*) FROM invoice; ";
                MySqlCommand command = new MySqlCommand(sqlText, con);

                command.ExecuteScalar().ToString();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return int.Parse(reader[0].ToString());
                        //read the Count of the Invoices
                    }
                    return -1;
                }
            }
        }

        public void UpdateQuantity(int ItmeQuantity,string ItemName)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"UPDATE items SET Quantity=Quantity-{ItmeQuantity} WHERE Product_Name =\"{ItemName}\";";
                MySqlCommand command = new MySqlCommand(sqlText, con);

                command.ExecuteNonQuery();
            }
        }

        public void InserIntoInvoiceItems(int ItemBarcode, int Quantity,double Single_Price, double Total,int Invoice_Id)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"INSERT INTO invoice_items (Item_Id,Quantity,Single_Price,Total,Invoice_Id)  VALUE({ItemBarcode}, {Quantity},{Single_Price}, {Total}, {Invoice_Id});";
                MySqlCommand command = new MySqlCommand(sqlText, con);
               // Console.WriteLine(Single_Price);
                command.ExecuteNonQuery();
            }
        }

        public double GetItemSinglePrice(int ItemBarcode)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"SELECT Single_Price  FROM items WHERE Id ={ItemBarcode};";
                MySqlCommand command = new MySqlCommand(sqlText, con);

                command.ExecuteScalar().ToString();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return double.Parse(reader[0].ToString());
                        //read the Count of the Invoices
                    }
                    return -1;
                }
            }
        }

        public string GetItemName(int ItemBarcode)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"SELECT Product_Name  FROM items WHERE Id ={ItemBarcode};";
                MySqlCommand command = new MySqlCommand(sqlText, con);

                command.ExecuteScalar().ToString();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader[0].ToString();
                        //read the Count of the Invoices
                    }
                    return String.Empty;
                }
            }
        }

        public int GetEmployeeId(string EmployeeName)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"SELECT Id FROM employees WHERE First_Name = \"{EmployeeName}\"; ";
                MySqlCommand command = new MySqlCommand(sqlText, con);

                command.ExecuteScalar().ToString();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return int.Parse(reader[0].ToString());
                        //return the Id of Employee
                    }
                    return -1;
                }
            }
        }

        public double GetTotal(int InvoiceId)
        {
            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"SELECT SUM(Total) FROM invoice_items WHERE Invoice_Id = {InvoiceId}; ";
                MySqlCommand command = new MySqlCommand(sqlText, con);

                command.ExecuteScalar().ToString();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return double.Parse(reader[0].ToString());
                        //return the Id of Employee
                    }
                    return -1;
                }
            }
        }

        public void InsertInvoice(int InvoiceNumber,string Date,string Time,int EmployeeId,double Total)
        {

            using (MySqlConnection con = new MySqlConnection(ConectionString)) //Performs Connection
            {
                con.Open();
                string sqlText = $"INSERT INTO invoice(Order_No, Date, Time, Employee_Id, Total, Payment_Method_Id,Store_Info_Id) VALUE({InvoiceNumber},\"{Date}\",\"{Time}\",{ EmployeeId},{Total},1,1); ";
                MySqlCommand command = new MySqlCommand(sqlText, con);
                command.ExecuteNonQuery();
            }
        }
    }
}
