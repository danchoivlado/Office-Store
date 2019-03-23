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
        public MainFormDB()
        {

        }
        
        public int GetInvoiceId()
        {
            string str = @"Server=localhost;database=HardwareStore;port=3306;user=root;password=3073";
            //Connection String
            using (MySqlConnection con = new MySqlConnection(str)) //Performs Connection
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
            string str = @"Server=localhost;database=HardwareStore;port=3306;user=root;password=3073";
            //Connection String
            using (MySqlConnection con = new MySqlConnection(str)) //Performs Connection
            {
                con.Open();
                string sqlText = $"UPDATE items SET Quantity=Quantity-{ItmeQuantity} WHERE Product_Name =\"{ItemName}\";";
                MySqlCommand command = new MySqlCommand(sqlText, con);

                command.ExecuteNonQuery();
            }
        }

        public void InserIntoInvoiceItems(int ItemBarcode, int Quantity,double Single_Price, double Total,int Invoice_Id)
        {
            string str = @"Server=localhost;database=HardwareStore;port=3306;user=root;password=3073";
            //Connection String
            using (MySqlConnection con = new MySqlConnection(str)) //Performs Connection
            {
                con.Open();
                string sqlText = $"INSERT INTO invoice_items (Item_Id,Quantity,Single_Price,Total,Invoice_Id)  VALUE({ItemBarcode}, {Quantity},{Single_Price}, {Total}, {Invoice_Id});";
                MySqlCommand command = new MySqlCommand(sqlText, con);
                Console.WriteLine(Single_Price);
                command.ExecuteNonQuery();
            }
        }

        public double GetItemSinglePrice(int ItemBarcode)
        {
            string str = @"Server=localhost;database=HardwareStore;port=3306;user=root;password=3073";
            //Connection String
            using (MySqlConnection con = new MySqlConnection(str)) //Performs Connection
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
            string str = @"Server=localhost;database=HardwareStore;port=3306;user=root;password=3073";
            //Connection String
            using (MySqlConnection con = new MySqlConnection(str)) //Performs Connection
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
    }
}
