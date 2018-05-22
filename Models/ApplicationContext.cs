using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace ASP.NET_CompanyEmployees_SQL_Server_EF_6.xx.Models
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext()
            : base("name=ModelEFCodeFirst")
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}