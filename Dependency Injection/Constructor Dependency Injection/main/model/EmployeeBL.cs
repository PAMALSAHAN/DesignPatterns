using System.Collections.Generic;

namespace main.model
{
    public class EmployeeBL
    {
        EmployeeDAL employeeDAL;
        public List<Employee> GetAllEmployee()
        {
            employeeDAL=new EmployeeDAL();
            return employeeDAL.SelectAllEmployee();  //emp objects tinne mekene
            
        }
    }
}