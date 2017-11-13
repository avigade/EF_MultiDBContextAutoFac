using GenericLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transactions.Models;
using Transactions.Repository;

namespace Transactions.Services
{
    public interface ITransactionService : IEntityService<Transaction>
    {
        Transaction GetById(int id);

        void AddTrans(Transaction trans);
    }
}
