using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityAccess.Models
{
    public class IdentityAccessContext : DbContext
    {
        public IdentityAccessContext()
            : base("IdentityDB")
        {

        }

        DbSet<TezIdentity> TezIdentity { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
