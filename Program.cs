using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Assignment2409
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("***EMPLOYEE TABLE***");
            List<Employee> employee = await EmployeeData.GetEmployeeAsync();
            Console.WriteLine(employee.Count);
            Console.WriteLine(string.Join("\n", employee.OrderBy(e => e.Id)));
            Console.WriteLine("----------------------------------------------------");


            Console.WriteLine("Employee with Highest pay: ");
            foreach (var emp in EmployeeStructure.CalculateSalary(employee))
            {
                EmployeeStructure.PrintInfo(emp);
            }
            Console.WriteLine("----------------------------------------------------");


            Console.WriteLine("Employee with salary higher than RS.50,000 are: ");
            foreach (var emp in EmployeeStructure.HighSalary(employee))
            {
                EmployeeStructure.PrintInfo(emp);
            }
            Console.WriteLine("----------------------------------------------------");


            Console.WriteLine("Employees with IT Department  are: ");
             foreach (var emp in EmployeeStructure.GetDepartment(employee, "IT"))
             {
                 EmployeeStructure.PrintInfo(emp);
             }

            Console.ReadLine();
        }
    }
}