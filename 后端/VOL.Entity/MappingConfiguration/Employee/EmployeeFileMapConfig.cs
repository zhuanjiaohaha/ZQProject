using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class EmployeeFileMapConfig : EntityMappingConfiguration<EmployeeFile>
    {
        public override void Map(EntityTypeBuilder<EmployeeFile>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

