using System;
using System.Collections.Generic;

namespace classes
{
  public class Employee
  {
    public string firstName { get; }
    public string lastName { get; }
    public string title { get; }
    public DateTime startDate { get; }

    public Employee(string givenFirstName, string givenLastName, string givenTitle, DateTime givenStartDate)
    {
      firstName = givenFirstName;
      lastName = givenLastName;
      title = givenTitle;
      startDate = givenStartDate;
    }

  }
  public class Company
  {

    // Some readOnly properties (let's talk about gets, baby)
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a public property for holding a list of current employees
    public List<Employee> employeeList { get; }

    public Company(string companyName, DateTime foundedOn)
    {
      Name = companyName;
      CreatedOn = foundedOn;
      employeeList = new List<Employee>();
    }

    public void addEmployee(Employee employee)
    {
      employeeList.Add(employee);
    }

    public void ListEmployees()
    {
      if (employeeList.Count > 0)
      {
        foreach (Employee employee in employeeList)
        {
          Console.WriteLine($"{employee.firstName} {employee.lastName} works for {this.Name}. as {employee.title} since {employee.startDate}");
        }
      }
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      // Create an instance of a company. Name it whatever you like.
      Company CookOut = new Company("Cook-Out", new DateTime(1982, 1, 1));

      // Create three employees
      Employee Sam = new Employee("Sam", "Sammy", "Manager", new DateTime(2019, 5, 13));
      Employee Trev = new Employee("Trev", "Chadson", "Burger Maestro", new DateTime(2020, 7, 11));
      Employee Devin = new Employee("Devin", "Raddude", "Master of Sass", new DateTime(2020, 3, 3));

      // Assign the employees to the company
      CookOut.addEmployee(Sam);
      CookOut.addEmployee(Trev);
      CookOut.addEmployee(Devin);
      /*
          Iterate the company's employee list and generate the
          simple report shown above
      */
      CookOut.ListEmployees();
    }
  }
}
