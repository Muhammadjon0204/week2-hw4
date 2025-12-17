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

}
