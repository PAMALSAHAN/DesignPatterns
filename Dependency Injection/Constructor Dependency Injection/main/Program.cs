using System;
using System.Collections.Generic;
using main.model;
namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EmployeeBL employeeBL=new EmployeeBL();
            int count=0;
            List<Employee> employeeList = employeeBL.GetAllEmployee();
            foreach (Employee item in employeeList)
            {
                count++;
                System.Console.Write($"Name {count} :{item.Name}");
                System.Console.WriteLine($" Department :{item.Department}");
            }

            
        }
    }
}
