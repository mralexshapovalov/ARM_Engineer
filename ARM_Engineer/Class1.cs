using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_Engineer
{
    class Class1
    {
        public static int A()
        {
            char n = Convert.ToChar(Console.ReadLine());

            while (true)
            {
                //{
                //    if((Program.States)n == Program.States.MainMenu ||(Program.States) n == Program.States.EmployeeMenu)
                //    {
                //        return n;
                //    }
                //    else if(ConsoleKey.Escape)
                //    {

                //    }



                //    else
                //    {
                //        Console.WriteLine("Ошибка!.Повторите снова");
                //    }
                //}

                ConsoleKeyInfo value = Console.ReadKey();

                switch (value.Key)
                {
                    case ConsoleKey.D1:
                        ConsoleInterface.ShowEmployeeMenu();

                        while (true)
                        {
                            value = Console.ReadKey();
                        }

                        break;
                    case ConsoleKey.D2:
                        ConsoleInterface.ShowTechiqueMenu();
                        value = Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        ConsoleInterface.ShowPartMenu();
                        value = Console.ReadKey();
                        break;
                    case ConsoleKey.Escape:
                        return 0;
                        break;
                    default:
                        Console.WriteLine("Такой команды не существует. Повторите снова.");
                        break;



                }
            }
        }
    }
}
