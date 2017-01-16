public class Encapuslation
{
    public static void Main(string[] args)
    {
        Employe employee = new Employe("Ivan", 18);
        System.Console.WriteLine(employee.Name);
        System.Console.WriteLine(employee.Age);
        employee.Age = 50;
        System.Console.WriteLine(employee.Age);
        employee.MonthlySalary = 500;
        System.Console.WriteLine(employee.MonthlySalary);
        employee.IsHired = true;
        System.Console.WriteLine(employee.IsHired);

        Department department = new Department("Development");

        department.AddEmployee(employee);

    }
}

