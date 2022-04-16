using ApartmentManagement.Data.Concrete.EntityFramework.Mappings;
using ApartmentManagement.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Data.Concrete.EntityFramework.Contexts
{
    public class ApartmentManagementContext : DbContext
    {
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server = LAPTOP-G4LV03N5;Database = ApartmentManagement;Trusted_Connection = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApartmentMap());
            modelBuilder.ApplyConfiguration(new ManagerMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            
        }
    }
}
