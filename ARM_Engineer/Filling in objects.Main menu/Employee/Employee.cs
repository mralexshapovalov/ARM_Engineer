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

        static Employee EditEmployeeMenu(Employee employee)
        {

            Console.WriteLine("Выбирете действие:");
            Console.WriteLine("1. Edit name");
            Console.WriteLine("2. Edit surname");
            Console.WriteLine("3. Edit patronymic");
            Console.WriteLine("4. Edit description");
            Console.WriteLine("5. Edit date of birthday");
            Console.WriteLine("6. Edit post");
            Console.WriteLine("7. Edit salary");
            Console.Write(">> ");
            
            int n = Convert.ToInt32(Console.ReadLine());
         
            switch(n)
            {
                case 1:
                    Console.Write("Введите новое имя: ");
                    string name = Console.ReadLine();
                    employee.Name = name;
                    return employee;
                case 2:
                    Console.Write("Введите новую фамилию: ");
                    string surname = Console.ReadLine();
                    employee.Surname = surname;
                    return employee;
                case 3:
                    Console.Write("Введите новое отчество: ");
                    string patronymic = Console.ReadLine();
                    employee.Patronymic = patronymic;
                    return employee;
                case 4:
                    Console.Write("Введите новую дату рождения: ");
                    DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
                    employee.DateOfBirth = dateOfBirth;
                    return employee;
                case 5:
                    Console.Write("Введите новую должность: ");
                    string post = Console.ReadLine();
                    employee.Post = post;
                    return employee;
                case 6:
                    Console.Write("Введите новую зараплату: ");
                    double salary = Convert.ToDouble(Console.ReadLine());
                    employee.Salary = salary;
                    return employee;
                default:
                    Console.WriteLine("\n!ERROR.There is no such command. Please repeat again.");
                    throw new NotImplementedException();

            }
        }
        


        static public void EditEmployeeWithConsole(List<Employee> employee)
        {
            Console.Write("Enter id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < employee.Count; i++)
            {
                if (employee[i].Id == id)
                { 
                   try
                   {
                       employee[i] = EditEmployeeMenu(employee[i]);
                       return;
                   }
                   catch
                   {
                       Console.WriteLine("Неизвестная команда");

                   } 
                } 
            }
            Console.WriteLine("Не найдет id номер.");

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
