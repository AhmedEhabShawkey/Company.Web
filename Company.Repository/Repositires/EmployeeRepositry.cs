using Company.Data.Contexr;
using Company.Data.Models;
using Company.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repository.Repositires
{
    public class EmployeeRepositry :GenericRepository<Employee>  ,IEmployeeRepositiory
    {


        public EmployeeRepositry(CompanyContext context):base(context) {
    
        }

        public Employee GetEmployeeName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployeesbyAdress(string Adresss)
        {
            throw new NotImplementedException();
        }
    }
}
