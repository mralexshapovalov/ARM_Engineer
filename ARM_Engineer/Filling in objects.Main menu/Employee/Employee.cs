using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ARM_Engineer.Employee
{
    public class Employee
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
        public Employee(int id, string surname, string name, string patronymic,
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

        static public Employee CreateEmployeeWithConsole()
        {
            Console.Write("Enter Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter Patronymic: ");
            string patronymic = Console.ReadLine();
            Console.Write("Enter Description: ");
            string description = Console.ReadLine();
            Console.Write("Enter Date of birthday: ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter Post: ");
            string post = Console.ReadLine();
            Console.Write("Enter salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Данные успешно записаны");
            ConsoleInterface.ShowEmployeeMenu();

            return new Employee(id, name, surname, patronymic, description, dateOfBirth, post, salary);
        }
        static public List<Employee> ReadDataBaseToList()
        {
            throw new NotImplementedException();
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
