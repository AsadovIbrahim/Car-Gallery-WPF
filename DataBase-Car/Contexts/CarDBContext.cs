using CarDB.Configurations;
using CarDB.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDB.Contexts
{
    public class CarDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-G25JVEL\\SQLEXPRESS;Initial Catalog=CarDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CarConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Admin>? Admin { get; set; }
        public DbSet<Car>? Cars { get; set; }
    }
}
