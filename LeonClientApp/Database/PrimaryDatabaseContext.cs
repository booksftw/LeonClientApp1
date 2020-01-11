using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LeonClientApp.Models;
using System.ComponentModel.DataAnnotations;
using System;

namespace LeonClientApp.Database
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
            optionsBuilder.UseSqlite("Data Source=LeonClientTracker.db");
            //optionsBuilder.UseSqlite("Data Source=/home/znick46/LeonClientApp/LeonClientApp/LeonClientTracker.db"); // Find a way to get the root of this app directory path instead of hard code
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
