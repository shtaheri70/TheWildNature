using TheWildNature.Application.Contracts.Repositories.PlaceDetailsRepository;
using TheWildNature.Domain.Entities.PlaceDetails;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.PlaceDetailsRepository
{
    public class PlaceDetailsRepositor : GenericRepository<PlaceDetails>,IPlaceDetailsRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public PlaceDetailsRepositor(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
