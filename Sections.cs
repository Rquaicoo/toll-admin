using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollAdmin
{
    internal static class Sections
    {
        static void UserManagement ()
        {
            Console.WriteLine("What task do you want to perform?");
            Console.WriteLine("_________________________________");
            Console.WriteLine("Select a task to continue"
                + "\n 1. Create new user  \n 2. Get user details  \n 3. Update user details  \n 4.Delete user");

            int selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    createUser();
                    break;
                case 2:
                    Console.WriteLine("Hello World");
                    break;
                case 3:
                    Console.WriteLine("Hello World");
                    break;
                case 4:
                    Console.WriteLine("Hello World");
                    break;
            }


                

        }

        private void createUser()
        {
            string role = "";
            string gender = "";

            Console.WriteLine("Input the name of the user");
            string name = Console.ReadLine();

            Console.WriteLine("Input  username for " + name);
            string username = Console.ReadLine();

            Console.WriteLine("Input the phone number of " + name + " (eg. 024xxxxxxx)");
            string phone = Console.ReadLine();

            Console.WriteLine("Input the date of birth of " + name + " (format: dd-mm-yyyy");
            string dob = Console.ReadLine();

            Console.Writeline("Select the number corresponding to the role of the user" +
                "\n1. Admin  2. Supervisor  3. Attendant");

            int roleSelection = Convert.ToInt32(Console.ReadLine());

            switch (roleSelection)
            {
                case 1:
                    role = "admin";
                    break;
                case 2:
                    role = "supervisor";
                    break;
                case 3:
                    role = "attendant";
                    break;

            }

            Console.WriteLine("Select the number corresponding to the gender of " + name);
            int genderSelection = Console.ReadLine();

            switch (genderSelection)
            {
                case 1:
                    gender = "male";
                    break;
                case 2:
                    gender = "female";
                    break;

            }

            User user = new User();
            user.name = name;
            user.phone = phone;
            user.gender = gender;
            user.username = username;
            user.role = role;
            user.dob = dob;


        }
    }
}
