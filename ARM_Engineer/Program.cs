
using ARM_Engineer;

class Program
{
   enum States
   {
        MainMenu = 0,
        EmployeeMenu = 1,
        TechiqueMenu = 2,
        PartMenu = 3
   }

    private static void Main(string[] args)
    {

        List<Employee> employees = new List<Employee>();
       
        States state = States.EmployeeMenu;
        ConsoleKey command = ConsoleKey.Spacebar;

        ConsoleInputInterpreter consoleInputInterpreter = new ConsoleInputInterpreter(employees);

        while (true)
        {
            switch (state)
            {
                case States.MainMenu:
                    ConsoleInterface.ShowMainMenu();

                    break;
                case States.EmployeeMenu:
                    ConsoleInterface.ShowEmployeeMenu();
                    consoleInputInterpreter.InterpretEmployeeCommand(command);
                    break;
                case States.TechiqueMenu:
                    ConsoleInterface.ShowTechiqueMenu();
                    break;
                case States.PartMenu:
                    ConsoleInterface.ShowPartMenu();
                    break;
                default:
                    Console.Write("\n!ERROR.There is no such command. Please repeat again.\n");
                    ConsoleInterface.ShowMainMenu();
                    break;
            }
            Console.Write(">> ");
            command = Console.ReadKey().Key;
            Console.WriteLine();

            
             

        }

        


    }
}
