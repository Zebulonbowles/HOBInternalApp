using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    interface IEmployeeRepository
    {
        public Task<EmployeeDTO> CreateEmployee(EmployeeDTO employeeDTO);
        public Task<EmployeeDTO> UpdateEmployee(int employeeId, EmployeeDTO employeeDTO);
        public Task<EmployeeDTO> GetEmployee(int employeeId);
        public Task<IEnumerable<EmployeeDTO>> GetAllEmployees();
        public Task<int> DeleteEmployee(int employeeId);
    }
}
