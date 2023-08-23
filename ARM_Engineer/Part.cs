using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_Engineer
{
    class Part
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
        public string Uzel { get; set; } //Узел
        public double Cost { get; set; } //Цена

        public Part(int id, string article, string nameParts, string unitofMeanSurement, string unit, string uzel,
            double cost)
        {
            Id = id;
            Article = article;
            NameParts = nameParts;
            UnitofMeanSurement = unitofMeanSurement;
            Unit = unit;
            Uzel = uzel;
           
        }

        public Part(Part part)
        {
            Id = id;
            Article = part.Article;
            NameParts = part.NameParts;
            UnitofMeanSurement = part.UnitofMeanSurement;
            Unit = part.Unit;
            Uzel = part.Uzel;
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
