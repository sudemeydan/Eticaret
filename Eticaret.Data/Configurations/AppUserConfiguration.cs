using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Eticaret.Data.Configurations
{
    internal class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.Surname).HasColumnType("varchar(50)").IsRequired().HasMaxLength(50); ;
            builder.Property(x => x.Email).HasColumnType("varchar(50)").IsRequired().HasMaxLength(50); 
            builder.Property(x => x.Phone).HasColumnType("varchar(15)").HasMaxLength(15);
            builder.Property(x => x.Password).HasColumnType("varchar(50)").IsRequired().HasMaxLength(50);
            builder.Property(x => x.UserName).HasColumnType("varchar(50)").HasMaxLength(50);
            builder.HasData(
                new AppUser {
                Id = 1,
                CreateDate = DateTime.Now,
                UserName="Admin",
                Email="sudemeydan@gmail.com",
                IsActive=true,
                IsAdmin=true,
                Name="Test",
                Password="123456*",
                Surname="User"
                }
                );


        }
    }
}
