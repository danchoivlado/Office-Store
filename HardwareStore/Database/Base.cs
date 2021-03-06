﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStore.Database
{
    class Base
    {
        public Base()
        {

        }

        public string GetPasswordIfExists(string name)
        {
            string str = @"Server=localhost;database=HardwareStore;port=3306;user=root;password=3073";
            //Connection String
            using (MySqlConnection con = new MySqlConnection(str)) //Performs Connection
            {
                con.Open();
                string sqlText = $"SELECT Password FROM employees WHERE First_Name = \"{name}\"; ";
                MySqlCommand command = new MySqlCommand(sqlText, con);
                try
                {
                    command.ExecuteScalar().ToString();
                    // Asks if there is Employee with this name 
                }
                catch
                {
                    return String.Empty;
                    //there is no Employee with this name
                }

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader[0].ToString();
                        //read the password of the Employee
                    }

                }
            }
            return String.Empty;
        }

        public int GetTownsId(string TownName)
        {
            string str = @"Server=localhost;database=HardwareStore;port=3306;user=root;password=3073";
            //Connection String
            using (MySqlConnection con = new MySqlConnection(str)) //Performs Connection
            {
                con.Open();
                string sqlText = $"SELECT ID FROM towns WHERE Name = \"{TownName}\";";
                MySqlCommand command = new MySqlCommand(sqlText, con);
                try
                {
                    command.ExecuteScalar().ToString();
                    // Asks if there is Town with this name 
                }
                catch
                {
                    //there is no Town with this name
                    sqlText = $"INSERT INTO towns(name) VALUE(\"{TownName}\")";
                    command = new MySqlCommand(sqlText, con);
                    command.ExecuteNonQuery();

                    sqlText = $"SELECT ID FROM towns WHERE Name = \"{TownName}\";";
                    command = new MySqlCommand(sqlText, con);
                    command.ExecuteNonQuery();
                }

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return int.Parse(reader[0].ToString());
                        //return the id from towns
                    }

                }
                return -1;
            }
        }

        public void Register(string FirstName,string LastName,string Password,int TownId)
        {
            string str = @"Server=localhost;database=HardwareStore;port=3306;user=root;password=3073";
            //Connection String
            using (MySqlConnection con = new MySqlConnection(str)) //Performs Connection
            {
                con.Open(); //open the connection
                string sqlText = $"INSERT INTO employees(First_Name, Last_Name, Password, Duty_id, Town_Id) VALUE(\"{FirstName}\",\"{LastName}\",\"{Password}\",3,{TownId})";
                MySqlCommand command = new MySqlCommand(sqlText, con);
                command.ExecuteNonQuery().ToString();
                //send the querry
            }
        }
    }
}
