using Employee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DB
{
    public class EmployeeRepository
    {
        public int EmployeeAdd(EmployeeModel model)
        {
            using (EmployeesEntities DB = new EmployeesEntities())
            {
                EmployeeDetail employee = new EmployeeDetail()
                {
                    FullName = model.FullName,
                    PhoneNo = model.PhoneNo,
                    Country = model.Country,
                    State = model.State,
                    Password = model.Password,
                    DateOfBirth = model.DateOfBirth,
                    EmployeeDepartment = new EmployeeDepartment()
                    {
                        DepartmnetName = model.DepartmnetName
                    }
                };
                DB.EmployeeDetails.Add(employee);
                DB.SaveChanges();
            }

            return model.EmployeeId;
        }
    }
}
