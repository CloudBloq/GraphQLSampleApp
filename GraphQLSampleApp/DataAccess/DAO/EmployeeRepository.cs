using GraphQLSampleApp.DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSampleApp.DataAccess.DAO
{
    public class EmployeeRepository
    {
        private readonly SampleAppDbContext _sampleAppDbContext;

        public EmployeeRepository(SampleAppDbContext sampleAppDbContext)
        {
            _sampleAppDbContext = sampleAppDbContext;
        }

        public List<Employee> GetEmployees()
        {
            return _sampleAppDbContext.Employee.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = _sampleAppDbContext.Employee.Find(id);

            if (employee != null)
                return employee;

            return null;
        }

        public List<Employee> GetEmployeesWithDepartment()
        {
            return _sampleAppDbContext.Employee
                .Include(e => e.Department)
                .ToList();
        }

        public async Task<Employee> CreateEmployee(Employee employee)
        {
            await _sampleAppDbContext.Employee.AddAsync(employee);
            await _sampleAppDbContext.SaveChangesAsync();
            return employee;
        }
    }
}
