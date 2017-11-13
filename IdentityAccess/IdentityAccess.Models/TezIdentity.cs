using GenericLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityAccess.Models
{
    public class TezIdentity : Entity<int>
    {
        public string TezUserName { get; set; }
    }
}
