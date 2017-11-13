using GenericLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transactions.Models;

namespace Transactions.Repository
{
    public interface ITransactionRepository : IGenericRepository<Transaction>
    {
        Transaction GetById(long id);
    }
}
