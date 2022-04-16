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
    public class ApartmentMap : IEntityTypeConfiguration<Apartment>
    {
        public void Configure(EntityTypeBuilder<Apartment> builder)
        {
            builder.HasKey(a=>a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Type).IsRequired(true);
            builder.Property(a => a.Type).HasMaxLength(50);
            builder.Property(a=>a.ApartmentNo).IsRequired();
            builder.Property(a => a.ApartmentNo).HasMaxLength(50);
            builder.Property(a => a.Block).IsRequired();
            builder.Property(a => a.Floor).IsRequired();
            builder.Property(a => a.Status).IsRequired();
            builder.Property(a => a.Block).HasMaxLength(50);
            builder.Property(a => a.Floor).HasMaxLength(50);
            builder.Property(a => a.Status).HasMaxLength(50);
            // builder.Property(a => a.TenantId).IsRequired();
            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(100);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(100);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).HasMaxLength(100);
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.ToTable("Aparments");
            builder.HasData(
                new Apartment
                {
                    Id = 1,
                    ApartmentNo = 1,
                    Block = "A",
                    Floor = "1",
                    Status = "Dolu",
                    Type = "1+0",
                    //TenantId = new User{ Id=1},
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                },
                 new Apartment
                 {
                     Id=2,
                     ApartmentNo = 2,
                     Block = "A",
                     Floor = "1",
                     Status = "Boş",
                     Type = "1+1",
                     IsActive = true,
                     IsDeleted = false,
                     CreatedByName = "InitialCreate",
                     CreatedDate = DateTime.Now,
                     ModifiedByName = "InitialCreate",
                     ModifiedDate = DateTime.Now,
                 },
                 new Apartment
                 {
                     Id=3,
                     ApartmentNo = 3,
                     Block = "A",
                     Floor = "2",
                     Status = "Boş",
                     Type = "2+1",
                     IsActive = true,
                     IsDeleted = false,
                     CreatedByName = "InitialCreate",
                     CreatedDate = DateTime.Now,
                     ModifiedByName = "InitialCreate",
                     ModifiedDate = DateTime.Now,
                 },
                 new Apartment
                 {
                     Id=4,
                     ApartmentNo = 4,
                     Block = "A",
                     Floor = "2",
                     Status = "Boş",
                     Type = "3+1",
                     IsActive = true,
                     IsDeleted = false,
                     CreatedByName = "InitialCreate",
                     CreatedDate = DateTime.Now,
                     ModifiedByName = "InitialCreate",
                     ModifiedDate = DateTime.Now,
                 }


                ) ;
        }
    }
}
