using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TollAdmin
{
    internal class User
    {
        private int id;
        private string name;
        private string email;
        private string password;
        private string phone;
        private string gender;
        private string role;
        private DateTime dob;

        private User(int id, string name, string dob, string role, string email, string phone, string gender)
        {
            this.name = name;
            this.id = id;
            this.email = email;
            this.dob = DateTime.Parse(dob);
            this.role = role;
            this.phone = phone;
            this.gender = gender;
            this.password = "";

        }

        private string generatePassword ()
        {   
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            char[] passwordArray = new char[6];
            var random = new Random();

            return password;
        }

        private int create()
        {
            Console.WriteLine("Hello World");

            //connect to database

            try
            {
                string connectionCode = "server=russell;database=toll;uid=root;pwd=1Russell";

                MySqlConnection connection = new MySqlConnection(connectionCode);
                connection.Open();

                string statement = $"INSERT INTO `users`( )";
               
            }

            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return 0;
        }

        private int delete(string id)
        {
            return 1;
        }

        private int update(string id)
        {
            return 1;
        }

        private void get (string id)
        {
            
        }
        
        
    }
}
