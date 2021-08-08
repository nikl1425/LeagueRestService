using System;
using Microsoft.EntityFrameworkCore;
using DataService.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace DataService
{
    public class MySqlContext : DbContext
    {

        private readonly ILoggerFactory _loggerFactory;

        public DbSet<UserModel> Users { get; set; }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().ToTable("User");
            modelBuilder.Entity<UserModel>().Property(x => x.id).HasColumnName("id");
            modelBuilder.Entity<UserModel>().Property(x => x.firstName).HasColumnName("first_name");
            modelBuilder.Entity<UserModel>().Property(x => x.lastName).HasColumnName("first_name");
            modelBuilder.Entity<UserModel>().Property(x => x.age).HasColumnName("age");
            modelBuilder.Entity<UserModel>().Property(x => x.email).HasColumnName("email");
        }


    }

    
}
