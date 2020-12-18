using GraphQLSampleApp.DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSampleApp.DataAccess.DAO
{
    public class DepartmentRepository
    {
        private readonly SampleAppDbContext _sampleAppDbContext;

        public DepartmentRepository(SampleAppDbContext sampleAppDbContext)
        {
            _sampleAppDbContext = sampleAppDbContext;
        }

        public List<Department> GetAllDepartmentOnly()
        {
            return _sampleAppDbContext.Department.ToList();
        }

        public List<Department> GetAllDepartmentsWithEmployee()
        {
            return _sampleAppDbContext.Department
                .Include(d => d.Employees)
                .ToList();
        }

        public async Task<Department> CreateDepartment(Department department)
        {
            await _sampleAppDbContext.Department.AddAsync(department);
            await _sampleAppDbContext.SaveChangesAsync();
            return department;
        }
    }
}
