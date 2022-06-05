using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class OperationClaim
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IList<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
