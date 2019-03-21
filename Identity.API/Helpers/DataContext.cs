using Microsoft.EntityFrameworkCore;
using Identity.API.Entities;
using Microsoft.EntityFrameworkCore.Design;

namespace Identity.API.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public class IdentityContextDesignFactory : IDesignTimeDbContextFactory<DataContext>
        {
            public DataContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<DataContext>()
                    .UseSqlServer("Server=10.100.1.168;Initial Catalog=IdentityDB1;user id=spiproject; password=spiirresistable;");
                return new DataContext(optionsBuilder.Options);
            }
        }
    }
}