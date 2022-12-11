﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Organizations.Classifications
{
    internal interface IClassificationService :
        ICrudAppService<ClassificationDto,int,PagedAndSortedResultRequestDto,CreateClassification>

    {

    }
}
