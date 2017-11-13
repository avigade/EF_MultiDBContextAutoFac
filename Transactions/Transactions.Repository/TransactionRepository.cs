using GenericLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transactions.Models;
using System.Data.Entity;

namespace Transactions.Repository
{
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(DbContext context) 
            : base(context)
        {
        }

        public Transaction GetById(long id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
