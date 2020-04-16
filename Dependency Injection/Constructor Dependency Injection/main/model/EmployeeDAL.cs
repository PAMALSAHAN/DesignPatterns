using System.Collections.Generic;

namespace main.model
{
    public class EmployeeDAL
    {
        ///meka thamai data access layer eka
       public List<Employee> SelectAllEmployee( )
       {
           List<Employee> employeesList=new List<Employee>();
           employeesList.Add(

               new Employee(){
               Id=1,
               Name="pamal",
               Department="accounting"
           }

           );
           employeesList.Add(
               
               new Employee(){
               Id=2,
               Name="sahan",
               Department="finance"
           }

           );
           employeesList.Add(
               
               new Employee(){
               Id=3,
               Name="janani",
               Department="mathematics"
           }

           );
           employeesList.Add(
               
               new Employee(){
               Id=4,
               Name="chamath",
               Department="science"
           }

           );
           employeesList.Add(
               
               new Employee(){
               Id=1,
               Name="aktha",
               Department="computerscience"
           }

           );
           return employeesList;
       }
    }
}