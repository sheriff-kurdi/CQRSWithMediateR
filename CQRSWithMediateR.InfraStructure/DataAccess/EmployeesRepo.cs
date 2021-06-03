using CQRSWithMediateR.InfraStructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSWithMediateR.InfraStructure.DataAccess
{
    public class EmployeesRepo : IEmployeesRepo
    {
        private List<Employee> _employees;
        public EmployeesRepo()
        {
            _employees = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "sheriff", Position= "dev"},
                new Employee(){Id = 2, Name = "yasser", Position= "finance"},
            };
        }

        public List<Employee> GetAll()
        {
            return _employees;
        }

        public Employee Add(Employee employee)
        {
            _employees.Add(employee);
            return employee;
        }
    }
}
