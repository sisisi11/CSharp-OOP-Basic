using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Worker : Human
{
    private decimal weekSalary;
    private decimal workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorksHoursPerDay = workHoursPerDay;
    }

    public decimal WorksHoursPerDay
    {
        get { return this.workHoursPerDay; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }   
            this.workHoursPerDay = value;
        }
    }
    public decimal WeekSalary {
        get { return this.weekSalary; }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }

    private decimal CalculateSalaryPerHour()
    {
        return this.WeekSalary / (this.WorksHoursPerDay * 5m);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(base.ToString()).AppendLine($"Week Salary: {this.WeekSalary}")
            .AppendLine($"Hours per day: {this.WorksHoursPerDay}").AppendLine($"Salary per hour: {this.CalculateSalaryPerHour()}");
        return sb.ToString();
    }
}