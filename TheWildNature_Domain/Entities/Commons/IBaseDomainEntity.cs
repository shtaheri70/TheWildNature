using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWildNature.Domain.Entities.Commons
{
    public interface IBaseDomainEntity
    {
        public int Id { get; set; }
    }
}
