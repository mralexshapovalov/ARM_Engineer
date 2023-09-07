using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_Engineer
{
    static class ConsoleInterface
    {
        

        public static void ShowEmployeeMenu()
        {
            Console.WriteLine("\nEmployee Menu");
            Console.WriteLine("1. Fill out a new employee's card");
            Console.WriteLine("2. Edit employee card");
            Console.WriteLine("3. Fire an employee");
            Console.WriteLine("4. Output employee information");
            Console.WriteLine("5. Display a list of employees");
            Console.WriteLine("Esc. Return main menu");
        }

        public static void ShowTechiqueMenu()
        {
            Console.WriteLine("\nTechique Menu");
            Console.WriteLine("1. Add new techique");
            Console.WriteLine("2. Edit techique card");
            Console.WriteLine("3. Deleted techique");
            Console.WriteLine("4. Output techique information");
            Console.WriteLine("5. Display a list of techique");
            Console.WriteLine("Esc. Return main menu");
        }

        public static void ShowPartMenu()
        {
            Console.WriteLine("\nPart Menu");
            Console.WriteLine("1. Add new part");
            Console.WriteLine("2. Edit part card");
            Console.WriteLine("3. Deleted part");
            Console.WriteLine("4. Output part information");
            Console.WriteLine("4. Display a list of part");
            Console.WriteLine("Esc. Return main menu");
        }

        public static void ShowMainMenu()
        {
            Console.WriteLine("Main menu");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Employee");
            Console.WriteLine("2. Techique");
            Console.WriteLine("3. Part");
            Console.WriteLine("Esc. Exiting the program");
        }



    }
}
