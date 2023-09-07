using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace ARM_Engineer
{
    public class ConsoleInputInterpreter
    {
        

        public ConsoleInputInterpreter(List<Employee> employees)
        {
            Employees = employees;
        }
        public List<Employee> Employees { get; set; }

        public void InterpretEmployeeCommand(ConsoleKey command)
        {
           switch(command)
           {
                case ConsoleKey.D1:
                    Employee employee = Employee.CreateEmployeeWithConsole();
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                case ConsoleKey.D4:
                    break;
                case ConsoleKey.D5:
                    break;
                case ConsoleKey.Escape:
                    break;
           }
        }

    }
}
