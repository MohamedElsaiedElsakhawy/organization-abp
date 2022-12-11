using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Organizations.Classifications
{
    public class ClassificationDto:AuditedEntityDto<int>
    {
        public string Name { get; set; }
    }
}
