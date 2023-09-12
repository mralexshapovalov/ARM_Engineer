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

        States state = States.MainMenu;
        ConsoleKey command = 0;
   
        while (IsBoolen)
        {
            if (command == ConsoleKey.Escape)
                return;
        
            switch (state = (States)(int)Char.GetNumericValue(Convert.ToChar(command)))
            {
                case States.MainMenu:
                    ConsoleInterface.ShowMainMenu();
                    break;
                case States.EmployeeMenu:
                    ConsoleInterface.ShowEmployeeMenu();
                    consoleInputInterpreter.InterpretEmployeeCommand(command = (ConsoleKey)state);
                    break;
                case States.TechiqueMenu:
                    ConsoleInterface.ShowTechiqueMenu();
                    consoleInputIterpretatorTechnique.InterpretTechniquesCommand(command = (ConsoleKey)state);
                    break;
                case States.PartMenu:
                    ConsoleInterface.ShowPartMenu();
                    consoleInputIterpretatorPart.InterpretPartCommand(command = (ConsoleKey)state);
                    break;
                default:
                    Console.WriteLine("\n!ERROR.There is no such command. Please repeat again.");
                    ConsoleInterface.ShowMainMenu();
                    break;
            }

            if(IsBoolen)
            {
                Console.Write(">> ");
                command = Console.ReadKey().Key;
                Console.WriteLine();
            }
        }
    }
}
