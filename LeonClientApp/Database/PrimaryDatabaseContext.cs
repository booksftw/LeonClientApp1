using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LeonCustomerTracker.Models;
using System.ComponentModel.DataAnnotations;

namespace LeonCustomerTracker.Database
{
    public class PrimaryDatabaseContext : DbContext
    {
        private readonly IConfiguration _config;

        // ! Samples of Tables in DB
        //public DbSet<Blog> Blogs { get; set; }
        //public DbSet<Post> Posts { get; set; }
        public DbSet<Client> Clients { get; set; }

        public PrimaryDatabaseContext(DbContextOptions<PrimaryDatabaseContext> options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=tcp:leoncustomertracker20191217092838dbserver.database.windows.net,1433;Initial Catalog=LeonCustomerTracker20191217092838_db;Persist Security Info=False;User ID=znick46;Password=Zachary46!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PIGFLT3; Initial Catalog=leoncustomertracker;User Id=nz;Password=1");
            //optionsBuilder.UseSqlServer("Data Source=vmtest2; Initial Catalog=LeonCustomerTracker;User ID=sa;Password=Zachary46!");
            //optionsBuilder.UseSqlServer(_config["AzureDbConnString"]);
        }

        // Sample code for relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasKey(k => k.Id);

        }

        public class Client
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

    }
}
