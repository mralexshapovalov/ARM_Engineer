using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ARM_Engineer
{
    class Employee
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

        public string Surname { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Post { get; set; }
        public double Salary { get; set; }
        public Employee(int id ,string surname, string name, string patronymic, 
            string description, DateTime dateOfBirth, string post, double salary) 
        {
            Id = id;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Description = description;
            DateOfBirth = dateOfBirth;
            Post = post;
            Salary = salary;
        }

        public Employee(Employee employee) 
        {
            id = employee.id;
            Surname = employee.Surname;
            Name = employee.Name;
            Patronymic = employee.Patronymic;
            Description = employee.Description;
            DateOfBirth = employee.DateOfBirth;
            Post = employee.Post;
            Salary = employee.Salary;
        }

        public void AddEmployeeToDatabase()
        {
            throw new NotImplementedException();
        }

        public void DismissalEmployeeToDataBase(int id)
        {
            throw new NotImplementedException();
        }










    }
}
