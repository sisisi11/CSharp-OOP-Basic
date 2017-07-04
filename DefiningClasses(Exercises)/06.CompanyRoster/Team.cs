using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private List<Employee> listOfEmployee;

    public Team()
    {
        this.listOfEmployee = new List<Employee>();
    }
    public List<Employee> ListOfEmployee
    {
        get { return this.listOfEmployee; }
    }

    public void AddEmployee(Employee employee)
    {
        this.ListOfEmployee.Add(employee);
    }

    public IGrouping<string, Employee> DepartmentWithTheHighestAverageSalary()
    {
        var highestDepartment = this.ListOfEmployee.GroupBy(x => x.Department, x => x.Salary).OrderByDescending(x => x.Average()).First().Key;
        var result = this.ListOfEmployee.GroupBy(x => x.Department).Where(x => x.Key == highestDepartment).ToList()[0];

        return result;
    }
}