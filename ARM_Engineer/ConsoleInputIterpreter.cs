﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace ARM_Engineer
{
    public class ConsoleInputInterpreter
    {
        bool IsBoolen = true;
        public ConsoleInputInterpreter(List<Employee> employees)
        {
            Employees = employees;
        }
        public List<Employee> Employees { get; set; }
        
        public void InterpretEmployeeCommand(ConsoleKey command)
        {
            IsBoolen = true;
            while (IsBoolen)
            {
                switch (command)
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
                        ConsoleInterface.ShowMainMenu();
                        IsBoolen = false;
                        break;
                }

                if(IsBoolen == true)
                {
                    Console.Write(">> ");
                    command = Console.ReadKey().Key;
                    Console.WriteLine();
                }

                
            }
        }
    }
}
