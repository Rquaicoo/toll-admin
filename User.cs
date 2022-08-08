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
        private string username;
        private string name;
        private string email;
        private string password;
        private string phone;
        private string gender;
        private string role;
        private date dob;

        private User(string name, string dob, string role, string email, string phone, string gender)
        {
            this.name = name;
            this.email = email;
            this.dob = DateTime.Parse(dob);
            this.role = role;
            this.phone = phone;
            this.gender = gender;

        }

        private string generatePassword ()
        {   
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            char[] passwordArray = new char[8];
            var random = new Random();

            for (int i = 0; i < passwordArray.Length; i++)
                {
                    passwordArray[i] = characters[random.Next(characters.Length)];
                }

            var password = new String(passwordArray);

            return password;
        }

        private int create()
        {
            //connect to database
            string connectionCode = "server=russell;database=toll;uid=root;pwd=1Russell";
            MySqlConnection connection = new MySqlConnection(connectionCode);
            connection.Open();

            try
            {
                this.password = generatePassword();

                string statement = $"INSERT INTO users(username,name,email,dob,role,phone,gender,password) VALUES ('{this.username}','{this.name}','{this.email}','{this.dob}',''{this.role}','{this.phone}','{this.gender}','{this.password}')";

                MySqlCommand command = new MySqlCommand(statement, connection);
                command.ExecuteNonQuery();

                Console.WriteLine("User " + this.name + " successfully created");
               
            }

            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            finally
            {
                connection.Close();
            }
            return 0;
        }

        private void get (string id)
        
        {
            //connect to database
            string connectionCode = "server=russell;database=toll;uid=root;pwd=1Russell";
            MySqlConnection connection = new MySqlConnection(connectionCode);
            connection.Open();

            try
            {
                string statement = $"SELECT * FROM `users` WHERE id='{this.id}'";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            finally
            {
                connection.Close();
            }
            
        }

        private int delete(string id)
        {
            return 1;
        }

        private int update(string id)
        {
            return 1;
        }

        
        
        
    }
}
