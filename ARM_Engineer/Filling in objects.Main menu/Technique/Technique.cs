using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ARM_Engineer.Technique
{
    //В данном классе описывается изменение удаление и добавление техники
    public class Technique
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
        public string ClassOfEquipment { get; set; } //Класс техники
        public string Brand { get; set; } //Марка
        public string Model { get; set; } //Модель
        public string InventoryNumber { get; set; } //Инвентарный номер 
        public string StateNumber { get; set; } //Государственный номер
        public string IdentificationNumber { get; set; }  //Вин номер 
        public DateTime YearOfRelease { get; set; } //Год выпуска
        public double EngineCapacity { get; set; } //Объем двигателя
        public int HP { get; set; } //Лошадинные силы
        public Technique(int id, string classOfEquipment, string brand, string model, string inventoryNumber, string stateNumber, 
            string identificationNumber, DateTime yearOfRelease, double engineCapacity , int hp)
        {
            Id = id;
            ClassOfEquipment = classOfEquipment;
            Brand = brand;
            Model = model;
            InventoryNumber = inventoryNumber;
            StateNumber = stateNumber;
            IdentificationNumber = identificationNumber;
            YearOfRelease = yearOfRelease;
            EngineCapacity = engineCapacity;
            HP = hp;
        }
        public Technique(Technique technique)
        {
            Id = id;
            ClassOfEquipment = technique.ClassOfEquipment;
            Brand = technique.Brand;
            Model = technique.Model;
            InventoryNumber = technique.InventoryNumber;
            StateNumber = technique.StateNumber;
            IdentificationNumber = technique.IdentificationNumber;
            YearOfRelease = technique.YearOfRelease;
            EngineCapacity = technique.EngineCapacity;
            HP = technique.HP;
        }
        static public Technique CreateEmployeeWithConsole()
        {
            Console.Write("Enter Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter class of equipment: ");
            string classOfEquipment = Console.ReadLine();
            Console.Write("Enter brand: ");
            string brand = Console.ReadLine();
            Console.Write("Enter model: ");
            string model = Console.ReadLine();
            Console.Write("Enter inventory number: ");
            string inventoryNumber = Console.ReadLine();
            Console.Write("Enter identification number: ");
            string identificationNumber = Console.ReadLine();
            Console.Write("Enter state number: ");
            string stateNumber = Console.ReadLine();
            Console.Write("Enter year of release: ");
            DateTime year = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter engine capacity: ");
            double engineCapacity = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter HP: ");
            int HP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Данные успешно записаны");
            ConsoleInterface.ShowTechiqueMenu();

            return new Technique(id, classOfEquipment, brand, model, inventoryNumber, identificationNumber, stateNumber, year, engineCapacity, HP);
        }
        static Technique EditTechniqueMenu(Technique technique)
        {
            Console.WriteLine("Выбирете действие:");
            Console.WriteLine("1. Edit class of equipment");
            Console.WriteLine("2. Edit brand");
            Console.WriteLine("3. Edit model");
            Console.WriteLine("4. Edit inventory number");
            Console.WriteLine("5. Edit identification number");
            Console.WriteLine("6. Edit state number");
            Console.WriteLine("7. Edit year of release");
            Console.WriteLine("8. Enter engine capacity:");
            Console.WriteLine("9. Enter HP:");
            Console.Write(">> ");

            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.Write("Введите артикул: ");
                    string classOfEquipment = Console.ReadLine();
                    technique.ClassOfEquipment = classOfEquipment;
                    return technique;
                case 2:
                    Console.Write("Введите наименование: ");
                    string brand = Console.ReadLine();
                    technique.Brand = brand;
                    return technique;
                case 3:
                    Console.Write("Введите единицу измерения: ");
                    string model = Console.ReadLine();
                    technique.Model = model;
                    return technique;
                case 4:
                    Console.Write("Введите агрегат: ");
                    string inventoryNumber = Console.ReadLine();
                    technique.InventoryNumber = inventoryNumber;
                    return technique;
                case 5:
                    Console.Write("Введите узел: ");
                    string identificationNumber = Console.ReadLine();
                    technique.IdentificationNumber = identificationNumber;
                    return technique;
                case 6:
                    Console.Write("Введите стоимость: ");
                    string stateNumber = Console.ReadLine();
                    technique.StateNumber = stateNumber;
                    return technique;
                case 7:
                    Console.Write("Введите стоимость: ");
                    DateTime year = DateTime.Parse(Console.ReadLine());
                    technique.YearOfRelease = year;
                    return technique;
                case 8:
                    Console.Write("Введите стоимость: ");
                    double engineCapacity = Convert.ToDouble(Console.ReadLine());
                    technique.EngineCapacity = engineCapacity;
                    return technique;
                case 9:
                    Console.Write("Введите стоимость: ");
                    int hp = Convert.ToInt32(Console.ReadLine());
                    technique.HP = hp;
                    return technique;
                default:
                    Console.WriteLine("\n!ERROR.There is no such command. Please repeat again.");
                    throw new NotImplementedException();
            }
        }
        static public void EditTechniqueConsole(List<Technique> technique)
        {
            Console.Write("Enter id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < technique.Count; i++)
            {
                if (technique[i].Id == id)
                {
                    try
                    {
                        technique[i] = EditTechniqueMenu(technique[i]);
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

        public void AddTechniqueToDatabase()
        {
            throw new NotImplementedException();
        }
        public void DismissalTechniqueToDataBase(int id)
        {
            throw new NotImplementedException();
        }
    }
}
