using System;

namespace Domain.Models;

public class Employee
{

private string FirstName ;
private string LastName ;
private DateTime BirthDate ;

private double Salary ;

private Department Department;

public string firstName
    {
        get;
        set;
    }
public string lastName
    {
        get;
        set;
    }    
public DateTime birthDate
    {
        get;
        set;
    }    

public double salary
    {
        get;
        set;
    }
public Department department
    {
        get;
        set;
    }    

}
