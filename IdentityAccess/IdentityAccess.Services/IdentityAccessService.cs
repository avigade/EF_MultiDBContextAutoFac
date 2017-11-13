using GenericLib;
using IdentityAccess.Models;
using IdentityAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityAccess.Services
{
    public class IdentityAccessService : EntityService<TezIdentity>, IIdentityAccessService
    {
        IIdentityAccessRepository _identityRepo;
        IUnitOfWork _unitOfWork;
        public IdentityAccessService(IUnitOfWork unitOfWork, IIdentityAccessRepository repository) 
            : base(unitOfWork, repository)
        {
            _identityRepo = repository;
            _unitOfWork = unitOfWork;
        }

        public void AddIdentity(TezIdentity identity)
        {
            _identityRepo.Add(identity);
            _unitOfWork.Commit();
        }

        public TezIdentity GetById(int id)
        {
            return _identityRepo.GetById(id);
        }
    }
}
