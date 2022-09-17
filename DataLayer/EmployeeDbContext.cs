using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-7OG61VI\SQLEXPRESS; initial catalog=dbEmp;persist security info=True;user id=sa;password=123;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Employee> tbl_Employee { get; set; }
    }
}
