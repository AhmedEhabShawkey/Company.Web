using Company.Data.Models;
using Company.Repository.IGenericRepositiory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repository.Interface
{
    public interface IEmployeeRepositiory:IGenericRepository<Employee>
    {
        Employee GetEmployeeName(string name);
        IEnumerable<Employee> GetEmployeesbyAdress(string Adresss);

    }
}
