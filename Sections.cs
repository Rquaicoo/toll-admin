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
                    Console.WriteLine("Input the name of the user");
                    string name = Console.ReadLine();
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
    }
}
