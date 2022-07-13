using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTA.DrillingData.NTier.DataAccess.Concrete.EntityFramework.Mappings;
using YTA.DrillingData.NTier.Entities.Concrete;

namespace YTA.DrillingData.NTier.DataAccess.Concrete.EntityFramework
{
    public class DrillingDataContext : DbContext
    {
        public DrillingDataContext()
        {
            Database.SetInitializer<DrillingDataContext>(null);
        }

        public DbSet<DrillCollar> DrillCollars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DrillCollarMap());
        }
    }
}
