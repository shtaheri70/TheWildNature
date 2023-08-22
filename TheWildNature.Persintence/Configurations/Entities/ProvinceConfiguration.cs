using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using TheWildNature.Domain.Entities.City;

namespace TheWildNature.Persintence.Configurations.Entities
{
    public class ProvinceConfiguration : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder
              .HasData(
              new Province()
              {
                  Id = 1,
                  Name = "Tehran"
              },
               new Province()
               {
                   Id = 2,
                   Name = "Isfahan"
               },
                new Province()
                {
                    Id = 3,
                    Name = "Fars"
                }
              );

        }
    }
}
