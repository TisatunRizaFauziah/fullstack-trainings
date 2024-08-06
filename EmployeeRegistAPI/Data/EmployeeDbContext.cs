using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeRegistAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EmployeeRegistAPI.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext>options):base(options)
        {

        }

        public DbSet<Employee> Employees{get;set;}
    }
}