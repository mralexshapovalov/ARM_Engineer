
using ARM_Engineer;
using System.Runtime.InteropServices;

class Program
{
   enum States
   {
        MainMenu = -1,
        EmployeeMenu = 1,
        TechiqueMenu = 2,
        PartMenu = 3,
        Esc = ConsoleKey.Escape
   }

    private static void Main(string[] args)
    {
        bool IsBoolen = true;
        List<Employee> employees = new List<Employee>();

        States state = (States)0;
        ConsoleKey command = ConsoleKey.Spacebar;
        ConsoleInputInterpreter consoleInputInterpreter = new ConsoleInputInterpreter(employees);

        while (IsBoolen)
        {
            if(command == ConsoleKey.Escape)
            {
                return;
            }

            char s = Convert.ToChar(command);
            switch (state = (States)(int)Char.GetNumericValue(s))
            {
                case States.MainMenu:
                    ConsoleInterface.ShowMainMenu();
                    break;
                case States.EmployeeMenu:
                    ConsoleInterface.ShowEmployeeMenu();
                    consoleInputInterpreter.InterpretEmployeeCommand(command = 0);
                    break;
                case States.TechiqueMenu:
                    ConsoleInterface.ShowTechiqueMenu();
                    break;
                case States.PartMenu:
                    ConsoleInterface.ShowPartMenu();
                    break;
                case States.Esc:
                    IsBoolen = false;
               
                    break;
                
                default:
                    Console.Write("\n!ERROR.There is no such command. Please repeat again.\n");
                    ConsoleInterface.ShowMainMenu();
                    break;
            }
            if(IsBoolen  == true)
            {
                Console.Write(">> ");
                command = Console.ReadKey().Key;
                Console.WriteLine();
            }
           

        }

        


    }
}
