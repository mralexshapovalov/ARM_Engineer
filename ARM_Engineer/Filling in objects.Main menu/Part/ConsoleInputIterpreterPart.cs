using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;


namespace ARM_Engineer.Part
{
    public class ConsoleInputInterpreterPart
    {
        bool IsBoolen = true;
        public ConsoleInputInterpreterPart(List<Part> parts)
        {
            Parts = parts;
        }
        public List<Part> Parts { get; set; }
        public void InterpretPartCommand(ConsoleKey command)
        {
            while (IsBoolen)
            {
                switch (command)
                {
                    case ConsoleKey.D1:
                        Part parts = Part.CreatePartWithConsole();
                        break;
                    case ConsoleKey.D2:
                        Part.EditPartWithConsole(Parts);
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.D5:
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine();
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
