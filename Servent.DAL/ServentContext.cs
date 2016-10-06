using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Servent.DAL.Configurations;

using Servent.Domain;

namespace Servent.DAL
{
    public class ServentContext : DbContext
    {
        public ServentContext(): base("DBServent")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<ServentContext>());//Rever
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ServentContext>());
            if (!Settings.IsLocalServer)
                Database.Connection.ConnectionString = Settings.ConnectionString;
            Util.TraceHelper.WriteInEventVwr("Settings.IsLocalServer: " + Settings.IsLocalServer, EventLogEntryType.Information);
            Util.TraceHelper.WriteInEventVwr("ConnectionString: " + Database.Connection.ConnectionString, EventLogEntryType.Information);
            Stocks.Load();
            UnitTypes.Load();
            Materials.Load();
            Addresses.Load();
            ConstructionHistories.Load();
            Providers.Load();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MaterialsMovementConfiguration());
            modelBuilder.Configurations.Add(new ConstructionsConfigurations());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Construction> Construction { get; set; }
        public DbSet<ConstructionHistory> ConstructionHistories { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<MaterialsMovement> Stocks { get; set; }
        public DbSet<Material> Materials { get; set; }
    }
}
