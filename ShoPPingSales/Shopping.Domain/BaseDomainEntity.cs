using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Domain
{
    public class BaseDomainEntity
    {
        public Guid Id { get; set; }
        public DateTime CretedOn { get; set; }
        public DateTime LastTimeModified { get; set; }
    }
}
