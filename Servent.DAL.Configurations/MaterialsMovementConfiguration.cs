using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Servent.Domain;

namespace Servent.DAL.Configurations
{
    public class MaterialsMovementConfiguration : EntityTypeConfiguration<MaterialsMovement>
    {
        public MaterialsMovementConfiguration()
        {
            HasKey(a => a.ID);
            HasOptional(x => x.Material)
            .WithOptionalDependent();
           //.WillCascadeOnDelete(true);

        }
    }
}
