using System.Collections.Generic;
namespace mainCorrect.model
{
   public interface IEmployeeDAL
    {
        List<IEmployee> SelectAllEmployee();
    }
}