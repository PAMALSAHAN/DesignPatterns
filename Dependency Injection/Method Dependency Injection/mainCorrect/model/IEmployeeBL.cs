using System.Collections.Generic;
namespace mainCorrect.model
{
    public interface IEmployeeBL
    {
        List<IEmployee> GetAllEmployee(IEmployeeDAL employeeDAL);
    }
}