using System;
using mainCorrect.model;
using System.Collections.Generic;
namespace mainCorrect
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IEmployeeBL employeeBL=new EmployeeBL();
            employeeBL.employeeDALObject=new EmployeeDAL();
            int count=0;
            List<IEmployee> employeeList = employeeBL.GetAllEmployee();
            foreach (Employee item in employeeList)
            {
                count++;
                System.Console.Write($"Name {count} :{item.Name}");
                System.Console.WriteLine($" Department :{item.Department}");
            }

            
        }
    }
}
