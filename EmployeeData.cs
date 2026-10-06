using System;
using System.Collections.Generic;

namespace Assignment2409
{
    class EmployeeData
    {
        public static async Task<List<Employee>> GetEmployeeAsync()
        {
            Console.WriteLine("Fetching Employee data...\n");
            await Task.Delay(2000);
            return new List<Employee>
            {
                new Employee(101, "Abhay Chhetri", "IT",75000f),
                new Employee(102, "Diksha Bora", "HR", 85000f),
                new Employee(103, "Aditya Adhikari", "IT", 75000f),
                new Employee(104, "Seema Dubey", "HR", 80000f),
                new Employee(105, "Sunil Gurung", "FINANCE", 47000f),
            };
        }
    }
}