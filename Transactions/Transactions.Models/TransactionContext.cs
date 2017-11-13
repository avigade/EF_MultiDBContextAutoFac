using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transactions.Models;

namespace Transactions.Models
{
    public class TransactionContext : DbContext
    {
        public TransactionContext() : base("TransactDB")
        {

        }

        DbSet<Transaction> Transaction { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
