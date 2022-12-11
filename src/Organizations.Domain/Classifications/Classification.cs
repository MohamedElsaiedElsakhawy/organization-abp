using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Organizations.Classifications
{
    public class Classification : AuditedAggregateRoot<int>
    {
        public string Name { get; set; }
    }
}
