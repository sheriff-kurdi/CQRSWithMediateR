using CQRSWithMediateR.InfraStructure.Entities;
using System.Collections.Generic;

namespace CQRSWithMediateR.InfraStructure.DataAccess
{
    public interface IEmployeesRepo
    {
        Employee Add(Employee employee);
        List<Employee> GetAll();
    }
}