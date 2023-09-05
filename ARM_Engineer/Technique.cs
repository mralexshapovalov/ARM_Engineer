using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ARM_Engineer
{
    //В данном классе описывается изменение удаление и добавление техники
    class Technique
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
