using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Organizations.Classifications
{
    public class ClassificationService :
        CrudAppService<Classification, ClassificationDto, int, PagedAndSortedResultRequestDto, CreateClassification>
    {
        public ClassificationService(IRepository<Classification, int> repository) : base(repository)
        {
             
        }
    }
}
