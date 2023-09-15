using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_Engineer.Part
{
    public class Part
    {
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            private set { id = value; }
        }
        public string Article { get; set; } //Артикул
        public string NameParts { get; set; } //Наименование детали
        public string UnitofMeanSurement { get; set; } //Единица измерения
        public string Unit { get; set; } //Агрегат
        public string Node { get; set; } //Узел
        public double Cost { get; set; } //Цена
        public Part(int id, string article, string nameParts, string unitofMeanSurement, string unit, string node, double cost)
        {
            Id = id;
            Article = article;
            NameParts = nameParts;
            UnitofMeanSurement = unitofMeanSurement;
            Unit = unit;
            Node = node;
            Cost = cost;

        }
        public Part(Part part)
        {
            Id = id;
            Article = part.Article;
            NameParts = part.NameParts;
            UnitofMeanSurement = part.UnitofMeanSurement;
            Unit = part.Unit;
            Node = part.Node;
            Cost = part.Cost;
        }
        static public Part CreatePartWithConsole()
        {
            Console.Write("Enter Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter article: ");
            string article = Console.ReadLine();
            Console.Write("Enter name parts: ");
            string nameParts = Console.ReadLine();
            Console.Write("Enter unit of mean surement: ");
            string unitofMeanSurement = Console.ReadLine();
            Console.Write("Enter unit: ");
            string unit = Console.ReadLine();
            Console.Write("Enter node: ");
            string node = Console.ReadLine();
            Console.Write("Enter cost: ");
            double cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Данные успешно записаны");
            ConsoleInterface.ShowPartMenu();

            return new Part(id, article, nameParts, unitofMeanSurement, unit, node, cost);
        }
        static Part EditPartMenu(Part part)
        {
            Console.WriteLine("Выбирете действие:");
            Console.WriteLine("1. Edit article");
            Console.WriteLine("2. Edit parts");
            Console.WriteLine("3. Edit unit of mean surement");
            Console.WriteLine("4. Edit unit");
            Console.WriteLine("5. Edit date of birthday");
            Console.WriteLine("6. Edit node");
            Console.WriteLine("7. Edit cost");
            Console.Write(">> ");

            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.Write("Введите артикул: ");
                    string article = Console.ReadLine();
                    part.Article = article;
                    return part;
                case 2:
                    Console.Write("Введите наименование: ");
                    string nameParts = Console.ReadLine();
                    part.NameParts = nameParts;
                    return part;
                case 3:
                    Console.Write("Введите единицу измерения: ");
                    string unitofMeanSurement = Console.ReadLine();
                    part.UnitofMeanSurement = unitofMeanSurement;
                    return part;
                case 4:
                    Console.Write("Введите агрегат: ");
                    string unit = Console.ReadLine();
                    part.Unit = unit;
                    return part;
                case 5:
                    Console.Write("Введите узел: ");
                    string node = Console.ReadLine();
                    part.Node = node;
                    return part;
                case 6:
                    Console.Write("Введите стоимость: ");
                    double cost = Convert.ToDouble(Console.ReadLine());
                    part.Cost = cost;
                    return part;
                default:
                    Console.WriteLine("\n!ERROR.There is no such command. Please repeat again.");
                    throw new NotImplementedException();
            }
        }
        static public void EditPartWithConsole(List<Part> part)
        {
            Console.Write("Enter id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < part.Count; i++)
            {
                if (part[i].Id == id)
                {
                    try
                    {
                        part[i] = EditPartMenu(part[i]);
                        return;
                    }
                    catch
                    {
                        Console.WriteLine("Неизвестная команда");
                    }
                }
            }
            Console.WriteLine("Не найдет id номер.");
            ConsoleInterface.ShowPartMenu();
        }
        public void AddPartToDatabase()
        {
            throw new NotImplementedException();
        }
        public void DismissalPartToDataBase(int id)
        {
            throw new NotImplementedException();
        }
    }
}
