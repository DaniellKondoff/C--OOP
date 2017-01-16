using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mankind
{
   public class Worker : Human
    {
        private double weekSalary;
        private double workHourPerDay;
        private const int weekDays= 5;
        public Worker(string nameFirst, string nameLast,double weekSalary, double workHourPerDay)
            :base(nameFirst,nameLast)
        {
            this.WeekSalary = weekSalary;
            this.WorkHourPerDay = workHourPerDay;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
          private set
            {
                if (value<10)
                {
                    throw new ArgumentException("Expected value mismatch!Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public double WorkHourPerDay
        {
            get
            {
                return this.workHourPerDay;
            }
           private set
            {
                if (value<1 || value>12)
                {
                    throw new ArgumentException("Expected value mismatch!Argument: workHoursPerDay");
                }

                this.workHourPerDay = value;
            }
        }

        private double GetSalaryPerHour()
        {
            return (this.WeekSalary / (weekDays * this.WorkHourPerDay));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format($"First Name: {this.NameFirst}"));
            sb.Append(Environment.NewLine);
            sb.Append(String.Format($"Last Name: {this.NameLast}"));
            sb.Append(Environment.NewLine);
            sb.Append(String.Format($"Week Salary: {this.WeekSalary:f2}"));
            sb.Append(Environment.NewLine);
            sb.Append(String.Format($"Hours per day: {this.WorkHourPerDay:f2}"));
            sb.Append(Environment.NewLine);
            sb.Append(String.Format($"Salary per hour: {this.GetSalaryPerHour():f2}"));

            return sb.ToString();

        }
    }
}
