using System;
using System.Collections.Generic;
using System.Linq;

class Department
{
    private string name;
    private List<Employe> employees;
    private Employe highestPaidEmployee;


    public Department(string name)
    {
        this.Name = name;
        this.employees = new List<Employe>();
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if(value == null)
            {
                //throw
            }
            this.name = value;
        }
    }

    public object Environmet { get; private set; }

    public void AddEmployee(Employe employee)
    {
        this.employees.Add(employee);

        if (this.highestPaidEmployee == null || highestPaidEmployee.MonthlySalary < employee.MonthlySalary)
        {
            this.highestPaidEmployee = employee;
        }
        
    }

    public string GetAllEmployees()
    {
        return string.Join(Environment.NewLine, this.employees.Select(e => $"{e.Name}"));
    }

    public string GetHighestPaidEmployee()
    {
        return $"{this.highestPaidEmployee.Name}";
    }
}

