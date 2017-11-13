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
    public class TransactionService : EntityService<Transaction>, ITransactionService
    {
        public IUnitOfWork _unitOfWork;
        public ITransactionRepository _transactionRepo;

        public TransactionService(IUnitOfWork unitOfWork, ITransactionRepository transactionRepository) 
            : base(unitOfWork, transactionRepository)
        {
            _transactionRepo = transactionRepository;
            _unitOfWork = unitOfWork;
        }
        public Transaction GetById(int id)
        {
            return _transactionRepo.GetById(id);
        }

        public void AddTrans(Transaction trans)
        {
            _transactionRepo.Add(trans);
            _unitOfWork.Commit();
        }
    }
}
