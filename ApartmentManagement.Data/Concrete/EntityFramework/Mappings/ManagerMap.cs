using ApartmentManagement.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Data.Concrete.EntityFramework.Mappings
{
    public class ManagerMap : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.FirstName).IsRequired();
            builder.Property(m => m.FirstName).HasMaxLength(50);
            builder.Property(m => m.LastName).IsRequired();
            builder.Property(m => m.LastName).HasMaxLength(50);
            builder.Property(m => m.Email).IsRequired();
            builder.Property(m => m.Email).HasMaxLength(50);
            //builder.Property(m => m.Role).IsRequired();
            builder.Property(m => m.RoleId).IsRequired();
            builder.Property(m => m.PasswordHash).IsRequired();
            builder.Property(m => m.CreatedByName).IsRequired();
            builder.Property(m => m.CreatedByName).HasMaxLength(100);
            builder.Property(m => m.ModifiedByName).IsRequired();
            builder.Property(m => m.ModifiedByName).HasMaxLength(100);
            builder.Property(m => m.CreatedDate).IsRequired();
            builder.Property(m => m.ModifiedDate).HasMaxLength(100);
            builder.Property(m => m.IsActive).IsRequired();
            builder.Property(m => m.IsDeleted).IsRequired();
            builder.ToTable("Manager");
            builder.HasData(new Manager
            {
                Id = 1,
                FirstName = "Alican",
                LastName = "Kesen",
                Email = "ali@ali.com",
                RoleId = 1,
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                PasswordHash = Encoding.ASCII.GetBytes("f1b3c1b4c0335e6906ee0dcf96d0b617") //admin123
            }) ;
        }
    }
}
