using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSampleApp.DataAccess.Entity
{
    public class SampleAppDbContext : DbContext
    {
        public SampleAppDbContext(DbContextOptions<SampleAppDbContext> options) : base(options)
        {            
        }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<Department> Department { get; set; }
        
    }
}
