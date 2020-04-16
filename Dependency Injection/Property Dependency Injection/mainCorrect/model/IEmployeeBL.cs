using System.Collections.Generic;
namespace mainCorrect.model
{
       public interface IEmployeeBL
    {
        IEmployeeDAL employeeDALObject { get; set; }

        List<IEmployee> GetAllEmployee();
    }
}