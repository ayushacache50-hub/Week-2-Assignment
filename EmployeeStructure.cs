using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2409
{
    internal class EmployeeStructure
    {
        public static void PrintInfo<T>(T item)
        {
            // avoid calling ToString on a null reference
            Console.WriteLine(item?.ToString() ?? "null");
        }

        public static List<Employee> CalculateSalary(List<Employee> employee)
        {
           if (employee == null) throw new ArgumentNullException(nameof(employee));
            // guard against null entries inside the list
            return employee.Where(e => e != null && e.Salary == employee.Max(emp => emp.Salary)).ToList();
        }

        public static List<Employee> HighSalary(List<Employee> employee)
        {
            if (employee == null) throw new ArgumentNullException(nameof(employee));
            // guard against null entries inside the list
            return employee.Where(e => e != null && e.Salary > 50000).ToList();
        }

        public static List<Employee> GetDepartment(List<Employee> employee, string department)
        {
            if (employee == null) throw new ArgumentNullException(nameof(employee));
            // guard against null entries inside the list
            return employee.Where(e => e != null && e.Department == department).ToList();
        }
    }
}