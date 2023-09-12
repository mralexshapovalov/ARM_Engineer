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
