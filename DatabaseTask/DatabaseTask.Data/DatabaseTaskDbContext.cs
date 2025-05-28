using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<SickLeave> SickLeaves { get; set; }
        public DbSet<HealthCheck> HealthChecks { get; set; }
        public DbSet<Access> Accesses { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet <RentObject> RentObject { get; set; } // renamed from Object to avoid errors
        public DbSet<HintAndRequest> HintAndRequests { get; set; }
       
    }

}
