using CarDB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarDB.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Brand).IsRequired();
            builder.Property(p => p.Model).IsRequired();
            builder.Property(p => p.Year).IsRequired();
            builder.Property(p => p.ImagePath).IsRequired();

            builder.HasOne(p => p.User).WithMany(p => p.Cars).HasForeignKey(p => p.UserId);
        }
    }
}
