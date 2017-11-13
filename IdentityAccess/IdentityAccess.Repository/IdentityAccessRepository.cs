using GenericLib;
using IdentityAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityAccess.Repository
{
    public class IdentityAccessRepository : GenericRepository<TezIdentity>, IIdentityAccessRepository
    {
        public IdentityAccessRepository(DbContext context)
            : base(context)
        {

        }
        public TezIdentity GetById(long id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
