using GenericLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transactions.Models
{
    public class Transaction : Entity<int>
    {
        public string TransactionRef { get; set; }
    }
}
