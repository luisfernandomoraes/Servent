using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace Servent.DAL.Configurations
{
    public class MatrialsConfigurations : EntityTypeConfiguration<Domain.Material>
    {
        public MatrialsConfigurations()
        {
            HasOptional(x => x.TypeOfUnit);
        }
    }
}
