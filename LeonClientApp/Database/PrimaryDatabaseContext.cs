using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LeonCustomerTracker.Models;
using System.ComponentModel.DataAnnotations;
using System;

namespace LeonCustomerTracker.Database
{
    public class PrimaryDatabaseContext : DbContext
    {
        private readonly IConfiguration _config;

        public DbSet<Client> Client { get; set; }

        public PrimaryDatabaseContext(DbContextOptions<PrimaryDatabaseContext> options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("Data Source=LeonClientTracker.db");
			optionsBuilder.UseSqlite("Data Source=LeonClientTracker.db");
        }

        // Sample code for relationships and table init
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .ToTable("Client")
                .HasKey(k => k.Id);
        }

        // Perhaps put this in it's own file later
        //public class Client
        //{
        //    [Required]
        //    public int Id { get; set; }
        //    public string firstName { get; set; }
        //    public string lastName { get; set; }
        //    public DateTime birthday { get; set; } // Todo Consider update type in future
        //    public int totalSpending { get; set; }
        //}

    }
}
