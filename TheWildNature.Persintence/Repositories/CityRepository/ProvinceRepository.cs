using TheWildNature.Application.Contracts.Repositories.CityRepository;
using TheWildNature.Domain.Entities.City;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.CityRepository
{
    public class ProvinceRepository: GenericRepository<Province>, IProvinceRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public ProvinceRepository(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
