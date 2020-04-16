using System.Collections.Generic;

namespace mainCorrect.model
{
   

    public class EmployeeDAL : IEmployeeDAL
    {
        ///meka thamai data access layer eka
        public List<IEmployee> SelectAllEmployee()
        {
            List<IEmployee> employeesList = new List<IEmployee>();
            employeesList.Add(

                new Employee()
                {
                    Id = 1,
                    Name = "pamal",
                    Department = "accounting"
                }

            );
            employeesList.Add(

                new Employee()
                {
                    Id = 2,
                    Name = "sahan",
                    Department = "finance"
                }

            );
            employeesList.Add(

                new Employee()
                {
                    Id = 3,
                    Name = "janani",
                    Department = "mathematics"
                }

            );
            employeesList.Add(

                new Employee()
                {
                    Id = 4,
                    Name = "chamath",
                    Department = "science"
                }

            );
            employeesList.Add(

                new Employee()
                {
                    Id = 1,
                    Name = "aktha",
                    Department = "computerscience"
                }

            );
            return employeesList;
        }
    }
}