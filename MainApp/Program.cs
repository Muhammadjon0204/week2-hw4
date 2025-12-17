
using Domain.Models;
using Infrastructure.Services;

var employeeServices = new EmployeeServices();
var departmentServices=new DepartmentServices();



var employee1=new Employee
{
    firstName="Joe",
    lastName="Doe",
    birthDate=new DateTime(2000,11,04),
    salary=2500
};
var employee2=new Employee
{
    firstName="Janifer",
    lastName="Lopez",
    birthDate=new DateTime(2000,11,04),
    salary=2800
};
var employee3=new Employee
{
    firstName="Tigger",
    lastName="Shroff",
    birthDate=new DateTime(2000,11,04),
    salary=2900
};

employeeServices.AddEmployees(employee1);
employeeServices.AddEmployees(employee2);
employeeServices.AddEmployees(employee3);

System.Console.WriteLine($"Kolichestvo sotrudnikov {employeeServices.CountEmployees()}");

var allEmployees=employeeServices.GetEmployees();

   foreach (var emp in allEmployees)
        {
            Console.WriteLine($"{emp.firstName} {emp.lastName} - ${emp.salary}");
        }
        
var department1=new Department
{
    name="IT",
    description="is services"
};
        
var department2=new Department
{
    name="SMM",
    description="is method to optimize service"
};

departmentServices.AddDepartaments(department1);
departmentServices.AddDepartaments(department2);

var allDepartments=departmentServices.GetDepartments();

foreach(var depr in allDepartments)
{
    System.Console.WriteLine($"{depr.name} {depr.description}");
}