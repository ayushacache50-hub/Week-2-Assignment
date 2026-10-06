using System;
using System.Collections.Generic;

namespace Assignment2409
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public float Salary { get; set; }


        public Employee(int id, string name, string department, float salary)
        {
            Id = id;
            Name = name; 
            Department = department;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"[{Id}] {Name} | {Department} | RS.{Salary}";
        }
    }
}