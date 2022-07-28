using System;
using System.Linq;

namespace TollAdministration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Russell's Toll Ticketing System");
            Console.WriteLine("___________________________________________\n" +
                "___________________________________________ \n");

            Console.WriteLine("Select the operation you want to perform \n" +
                "1. User Management  2. Station Management 3. Booth Management 4. Classification Management" );

            int selection = Convert.ToInt32( Console.ReadLine() );

            switch (selection)
            {
                case 1:
                    Console.WriteLine("You have selected User Management");
                    break;
                case 2:
                    Console.WriteLine("You have selected Station Management");
                    break ;
                case 3:
                    Console.WriteLine("You have selected Booth Management");
                    break;
                case 4:
                    Console.WriteLine("You have selected Classification Management");
                    break;
            }


        }
    }
}