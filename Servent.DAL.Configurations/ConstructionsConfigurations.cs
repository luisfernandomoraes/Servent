using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Servent.Domain;

namespace Servent.DAL.Configurations
{
    public class ConstructionsConfigurations : EntityTypeConfiguration<Construction>
    {
        public ConstructionsConfigurations()
        {
            HasKey(a => a.ID);

            HasOptional(x => x.Address)
            .WithOptionalDependent()
           .WillCascadeOnDelete(true);

            HasOptional(x => x.Address)
           .WithOptionalDependent()
           .WillCascadeOnDelete(true);
        }
    }
}
