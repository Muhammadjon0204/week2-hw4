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
        foreach(var item in departments)
        {
            if (item.name == name)
            {
                depr=item;
            }
            departments.Remove(depr);
        }

    }

}
