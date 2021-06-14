using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
      public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public EmployeeRepository(ApplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<EmployeeDTO> CreateEmployee(EmployeeDTO employeeDTO)
        {
            Employee employee = _mapper.Map<EmployeeDTO, Employee>(employeeDTO);

            var addedEmployee = await _db.Employees.AddAsync(employee);
            await _db.SaveChangesAsync();
            return _mapper.Map<Employee, EmployeeDTO>(addedEmployee.Entity);
        }

        public async Task<EmployeeDTO> GetEmployee(int employeeId)
        {
            try
            {
                EmployeeDTO employee = _mapper.Map<Employee, EmployeeDTO>(
                await _db.Employees.FirstOrDefaultAsync(x => x.EmployeeId == employeeId));
                return employee;
            }
            catch
            {
                return null;
            }
        }

        public async Task<IEnumerable<EmployeeDTO>> GetAllEmployees()
        {
            try
            {
                IEnumerable<EmployeeDTO> employeeDTOs =
                    _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeDTO>>(_db.Employees);

                return employeeDTOs;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<EmployeeDTO> UpdateEmployee(int employeeId, EmployeeDTO employeeDTO)
        {
            try
            {
                if (employeeId == employeeDTO.EmployeeId)
                {
                    var employeeDetails = await _db.Employees.FindAsync(employeeId);
                    var employee = _mapper.Map<EmployeeDTO, Employee>(employeeDTO, employeeDetails);
                    var updatedEmployee = _db.Employees.Update(employee);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<Employee, EmployeeDTO>(updatedEmployee.Entity);
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
        public async Task<int> DeleteEmployee(int employeeId)
        {
            var employee = await _db.Employees.FindAsync(employeeId);
            if (employee != null)
            {
                _db.Employees.Remove(employee);
                return await _db.SaveChangesAsync();

            }
            return 0;
        }
    }
}
