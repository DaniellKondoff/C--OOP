using System;

public class Employe
{
    private string name;
    private int age;
    private decimal salary;
   

    public Employe( string name, int age)
    {

        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
       private set
        {
            if(value==null || value.Length < 3)
            {
                throw new ArgumentException("Invalid Name");
            }
            this.name = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if(value < 18)
            {
                throw new ArgumentException("Invalid Age");

            }
            this.age = value;
        }
    }

    public decimal MonthlySalary
    {
        get
        {
            return this.salary;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid Salary");
            }

            if (value < 300)
            {
                throw new ArgumentException("Invalid Salary");
            }

            this.salary = value;
        }
    }

    public bool IsHired
    {
        get; set;
    }
     
    
}

