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
        for(int i=0; i<employees.Count ; i++)
        {
            if (employees[i].firstName == name)
            {
                employees.RemoveAt(i);
            }
            else
            {
                System.Console.WriteLine($"Employee with {name} can't be found!!");
            }
        }

    }

    

}
