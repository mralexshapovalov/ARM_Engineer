
using ARM_Engineer;

class Program
{
    private static void Main(string[] args)
    {

        Employee employeeOne = new Employee(001, "Шаповалов", "Александр", "Александрович", "-------", DateTime.Now, "-----", 10000);

      
        try
        {
            employeeOne.AddEmployeeToDatabase();
        }
        catch 
        {
            Console.WriteLine("Не удалось добавить сотрудника в БД.Повторит снова");
        }




    }
}