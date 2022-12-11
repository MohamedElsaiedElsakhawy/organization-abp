using Organizations.Classifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Organizations.DataSeed
{
    public class ClassificationSeeder : IDataSeedContributor, ITransientDependency
    {
        private IRepository<Classification, int> _repository;
        public ClassificationSeeder(IRepository<Classification,int> repository)
        {
            _repository = repository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _repository.GetCountAsync()<=0)
            {
                await _repository.InsertAsync(new Classification
                {
                    Name = "الدولية",
                }, autoSave: true);

                await _repository.InsertAsync(new Classification
                {
                    Name = "الخاصة",
                }, autoSave: true);
            }
        }
    }
}
