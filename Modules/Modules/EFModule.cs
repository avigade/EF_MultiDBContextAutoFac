using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Transactions.Models;
using System.Data.Entity;

namespace Modules
{
    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(TransactionContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
        }
    }
}
