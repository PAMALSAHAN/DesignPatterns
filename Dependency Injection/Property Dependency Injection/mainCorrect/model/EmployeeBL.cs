using System.Collections.Generic;

namespace mainCorrect.model
{
 

    public class EmployeeBL : IEmployeeBL
    {
        // IEmployeeDAL employeeDAL;
        // public EmployeeBL(IEmployeeDAL employeeDAL)
        // {
        //     this.employeeDAL=employeeDAL;
        // }

        // methanadi use karanne property field eka 

        private IEmployeeDAL employeeDAL;
        public IEmployeeDAL employeeDALObject
        {
            get
            {
                if (employeeDALObject == null)
                {
                    throw new System.Exception("not intialized");

                }
                else
                {
                    return employeeDAL;
                }
            }
            set { employeeDAL = value; }
        }

        public List<IEmployee> GetAllEmployee()
        {

            return employeeDAL.SelectAllEmployee();  //emp objects tinne mekene
        }
    }
}