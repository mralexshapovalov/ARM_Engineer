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
            string Node = Console.ReadLine();
            Console.Write("Enter cost: ");
            double cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Данные успешно записаны");
            ConsoleInterface.ShowPartMenu();

            return new Part(id, article, nameParts, unitofMeanSurement, unit, Node, cost);
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
