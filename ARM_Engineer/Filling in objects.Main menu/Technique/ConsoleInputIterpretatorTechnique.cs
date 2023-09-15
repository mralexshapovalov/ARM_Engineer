using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_Engineer.Technique
{
    class ConsoleInputIterpretatorTechnique
    {
        bool IsBoolen = true;
        public ConsoleInputIterpretatorTechnique(List<Technique> techniques)
        {
            Techniques = techniques;
        }
        public List<Technique> Techniques { get; set; }
        public void InterpretTechniquesCommand(ConsoleKey command)
        {
            IsBoolen = true;
            while (IsBoolen)
            {
                switch (command)
                {
                    case ConsoleKey.D1:
                        Technique techniques = Technique.CreateEmployeeWithConsole();
                        break;
                    case ConsoleKey.D2:
                        Technique.EditTechniqueConsole(Techniques);
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

                if (IsBoolen == true)
                {
                    Console.Write(">> ");
                    command = Console.ReadKey().Key;
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
