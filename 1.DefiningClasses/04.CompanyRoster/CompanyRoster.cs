using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Employee
{
    public Employee(string name, decimal salary, string position, string department)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = "n/a";
        this.age = -1;
    }
    public string name;
    public decimal salary;
    public string position;
    public string department;
    public string email;
    public int age;
}

public class CompanyRoster
{
    public static void Main()
    {

        int numberOfPeople = int.Parse(Console.ReadLine());
        var employeesList = new List<Employee>();

        for (int i = 0; i < numberOfPeople; i++)
        {
            var employeeInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var employee = new Employee(employeeInfo[0], decimal.Parse(employeeInfo[1]), employeeInfo[2], employeeInfo[3]);

            if (employeeInfo.Length > 4)
            {
                var ageOrEmail = employeeInfo[4];
                if (ageOrEmail.Contains("@"))
                {
                    employee.email = ageOrEmail;
                }
                else
                {
                    employee.age = int.Parse(ageOrEmail);
                }
            }

             if (employeeInfo.Length>5)

            {
                employee.age = int.Parse(employeeInfo[5]);
            }

            employeesList.Add(employee);
        }

        var result = employeesList
               .GroupBy(e => e.department)
               .Select(e => new
               {
                   Departament = e.Key,
                   AverageSalary = e.Average(emp => emp.salary),
                   Employess = e.OrderByDescending(emp => emp.salary)
               })
               .OrderByDescending(dep=>dep.AverageSalary)
               .FirstOrDefault();

        Console.WriteLine($"Highest Average Salary: {result.Departament}");

        foreach (var emp in result.Employess)
        {
            Console.WriteLine($"{emp.name} {emp.salary:F2} {emp.email} {emp.age}");
        }

    }
}

