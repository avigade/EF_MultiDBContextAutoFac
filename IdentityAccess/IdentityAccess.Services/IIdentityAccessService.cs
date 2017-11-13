using GenericLib;
using IdentityAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityAccess.Services
{
    public interface IIdentityAccessService : IEntityService<TezIdentity>
    {
        TezIdentity GetById(int id);

        void AddIdentity(TezIdentity identity);
    }
}
