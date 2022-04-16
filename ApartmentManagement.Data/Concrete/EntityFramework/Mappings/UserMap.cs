
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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(50);
            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(u => u.FirstName).IsRequired();
            builder.Property(u => u.FirstName).HasMaxLength(50);
            builder.Property(u => u.LastName).IsRequired();
            builder.Property(u => u.LastName).HasMaxLength(50);
            builder.Property(u => u.IdentityNo).IsRequired();
            builder.Property(u => u.IdentityNo).HasMaxLength(15);
            builder.Property(u => u.PhoneNumber).IsRequired();
            builder.Property(u => u.PhoneNumber).HasMaxLength(15);
            builder.Property(u => u.CarPlate).HasMaxLength(20);
            builder.Property(u => u.InvoiceElectricity).IsRequired();
            builder.Property(u => u.InvoiceWater).IsRequired();
            builder.Property(u => u.InvoiceGas).IsRequired();
            builder.Property(u => u.InvoiceInternet).IsRequired();
            builder.Property(u => u.InvoiceElectricity).HasMaxLength(15);
            builder.Property(u => u.InvoiceWater).HasMaxLength(15);
            builder.Property(u => u.InvoiceGas).HasMaxLength(15);
            builder.Property(u => u.InvoiceInternet).HasMaxLength(15);
            builder.Property(u => u.Dues).IsRequired();
            builder.Property(u => u.Dues).HasMaxLength(20);
            builder.Property(u => u.Dues).HasMaxLength(8);
           // builder.Property(u => u.Payment).IsRequired();
          //  builder.Property(u => u.Payment).HasMaxLength(8);
            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.PasswordHash).HasColumnType("VARBINARY(500)");
            builder.HasOne<Role>(u => u.Role).WithMany(r => r.Users).HasForeignKey(u => u.RoleId);
            builder.Property(u => u.CreatedByName).IsRequired();
            builder.Property(u => u.CreatedByName).HasMaxLength(100);
            builder.Property(u => u.ModifiedByName).IsRequired();
            builder.Property(u => u.ModifiedByName).HasMaxLength(100);
            builder.Property(u => u.CreatedDate).IsRequired();
            builder.Property(u => u.ModifiedDate).HasMaxLength(100);
            builder.Property(u => u.IsActive).IsRequired();
            builder.Property(u => u.IsDeleted).IsRequired();
            builder.ToTable("Users");

            builder.HasData(new User
            {
                Id = 1,
                RoleId = 2,
                FirstName = "Ad",
                LastName = "Soyad",
                Email = "adsoyad@adsoyad.com",
                CarPlate ="34 LOGO 34",
                Dues =  "100",
                IdentityNo="12345678901",
                PhoneNumber = "05551113322",
                InvoiceElectricity =200,
                InvoiceGas  = 300,
                InvoiceInternet = 100,
                InvoiceWater = 100,
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                PasswordHash = Encoding.ASCII.GetBytes("d2053a9a277357fa30ec40deee3b8e4d")//kullanıcı123
            }); ;

        }
    }
}
