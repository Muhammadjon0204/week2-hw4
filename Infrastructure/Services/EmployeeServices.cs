using System;
using Domain.Models;
namespace Infrastructure.Services;

public class EmployeeServices
{

private List<Employee> employees = new List<Employee>();



public List<Employee> GetEmployees()
{
return employees;
}

public void AddEmployees(Employee employee)
    {
       employees.Add(employee);
    }
public int CountEmployees()
    {
        return employees.Count;
    }

public void DeleteEmployeeByName(string name)
    {
        var emp=new Employee();
        foreach(var item in employees)
        {
            if (item.firstName == name)
            {
                emp=item;
            }
            employees.Remove(emp);
        }

    }

    

}
