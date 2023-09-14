using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;


namespace ARM_Engineer.Employee
{
    public class ConsoleInputInterpreterEmployee
    {
        bool IsBoolen = true;
        public ConsoleInputInterpreterEmployee(List<Employee> employees)
        {
            Employees = employees;
        }
        public List<Employee> Employees { get; set; }
        public void InterpretEmployeeCommand(ConsoleKey command)
        {
            while (IsBoolen)
            {
                switch (command)
                {
                    case ConsoleKey.D1:
                        Employee employee = Employee.CreateEmployeeWithConsole();
                        break;
                    case ConsoleKey.D2:
                        Employee.EditEmployeeWithConsole(Employees);
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.D5:
                        break;
                    case ConsoleKey.Escape:
                        Console.Write("\n");
                        ConsoleInterface.ShowMainMenu();
                        IsBoolen = false;
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
}
