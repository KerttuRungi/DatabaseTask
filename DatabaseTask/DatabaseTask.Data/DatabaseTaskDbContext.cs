using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<JobTitle> JobTitle { get; set; }
    }
}
