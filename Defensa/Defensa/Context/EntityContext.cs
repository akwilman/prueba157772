using Defensa.Business;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defensa.Context
{
    public partial class EntityContext : DbContext
    {
        public EntityContext()
            : base("name=DefensaDBEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Reading> Readings { get; set; }
    }
}
