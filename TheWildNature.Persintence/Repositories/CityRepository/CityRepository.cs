using TheWildNature.Application.Contracts.Repositories.CityRepository;
using TheWildNature.Domain.Entities.City;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.CityRepository
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public CityRepository(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
