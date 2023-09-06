
using ARM_Engineer;

class Program
{
   public enum States
    {
        MainMenu = 0,
        EmployeeMenu = 1,
        TechiqueMenu = 2,
        PartMenu = 3
    }

    private static void Main(string[] args)
    {
        ConsoleInterface.ShowMainMenu();
      
        while (true)
        {
            States state = (States)Class1.A();
            switch (state)
            {
                case States.MainMenu:
                    ConsoleInterface.ShowMainMenu();
                    break;
                case States.EmployeeMenu:
                    ConsoleInterface.ShowEmployeeMenu();
                    break;
                case States.TechiqueMenu:
                    ConsoleInterface.ShowTechiqueMenu();
                    break;
                case States.PartMenu:
                    ConsoleInterface.ShowPartMenu();
                    break;
                default:
                    Console.WriteLine("Такой команды не существует. Повторите снова.");
                    break;
            }
            

            //Console.WriteLine("\nВыберите вариант:");
            //Console.WriteLine("1. Сотрудники");
            //Console.WriteLine("2. Техника");
            //Console.WriteLine("3. Запасные части");
            //Console.WriteLine("Esc. Выход из программы");
            
            //ConsoleKeyInfo value = Console.ReadKey();

            //switch (value.Key) 
            //{
            //    case ConsoleKey.D1:
            //        ConsoleInterface.ShowEmployeeMenu();
                    
            //        while(true)
            //        {
            //           value = Console.ReadKey();
            //        }
                    
            //        break;
            //    case ConsoleKey.D2:
            //        ConsoleInterface.ShowTechiqueMenu();
            //        value = Console.ReadKey();
            //        break;
            //    case ConsoleKey.D3:
            //        ConsoleInterface.ShowPartMenu();
            //        value = Console.ReadKey();
            //        break;
            //    case ConsoleKey.Escape:
            //        return;
            //        break;
            //    default:
            //        Console.WriteLine("Такой команды не существует. Повторите снова.");
            //        break;
                   
                       
            
            

        }


    }
}
