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
            // optionsBuilder.UseSqlServer("Data Source=LeonClientTracker.db");
			optionsBuilder.UseSqlite("Data Source=LeonClientTracker.db");
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
