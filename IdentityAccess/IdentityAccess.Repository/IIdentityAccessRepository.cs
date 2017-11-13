using GenericLib;
using IdentityAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace IdentityAccess.Repository
{
    public interface IIdentityAccessRepository : IGenericRepository<TezIdentity>
    {
        TezIdentity GetById(long id);
    }
}
