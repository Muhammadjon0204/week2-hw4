using System;
using Domain.Models;
namespace Infrastructure.Services;

public class DepartmentServices
{

private List<Department> departments=new List<Department>();

public List<Department> GetDepartments()
    {
        return departments;
    }

public void AddDepartaments(Department department)
    {
        departments.Add(department);
    }    

public int CountDepartaments()
    {
        return departments.Count;
    }

public void DeleteDepartmentByName(string name)
    {
        var depr=new Department();
        for(int i=0 ; i<departments.Count ; i++)
        {
            if (departments[i].name == name)
            {
              departments.RemoveAt(i);
              System.Console.WriteLine($"Department with name {name} was deleted.");
            }
            else
            {
                System.Console.WriteLine($"The department with name {name} not found!");
            }
        }

    }

}
