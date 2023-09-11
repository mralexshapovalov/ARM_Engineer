using ARM_Engineer;
using ARM_Engineer.Employee;
using ARM_Engineer.Part;
using ARM_Engineer.Technique;
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
        List<Technique> techniques = new List<Technique>();
        List<Part> parts = new List<Part>();

        ConsoleInputInterpreterEmployee consoleInputInterpreter = new ConsoleInputInterpreterEmployee(employees);
        ConsoleInputIterpretatorTechnique consoleInputIterpretatorTechnique = new ConsoleInputIterpretatorTechnique(techniques);
        ConsoleInputInterpreterPart consoleInputIterpretatorPart = new ConsoleInputInterpreterPart(parts);

        States state = (States)0;
        ConsoleKey command = ConsoleKey.Spacebar;
       

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
                    consoleInputIterpretatorTechnique.InterpretTechniquesCommand(command = 0);
                    break;
                case States.PartMenu:
                    ConsoleInterface.ShowPartMenu();
                    consoleInputIterpretatorPart.InterpretPartCommand(command = 0);
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
