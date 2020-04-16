using System.Collections.Generic;

namespace mainCorrect.model
{
  

    public class EmployeeBL : IEmployeeBL
    {
         IEmployeeDAL employeeDAL;
        // public EmployeeBL(IEmployeeDAL employeeDAL)
        // {
        //     this.employeeDAL=employeeDAL;
        // }
        public List<IEmployee> GetAllEmployee(IEmployeeDAL employeeDAL)
        {
             this.employeeDAL=employeeDAL;
            return employeeDAL.SelectAllEmployee();  //emp objects tinne mekene

        }
    }
}