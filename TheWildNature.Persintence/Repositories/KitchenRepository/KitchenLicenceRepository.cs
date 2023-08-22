using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Domain.Entities.Kitchen;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.KitchenRepository
{
    public class KitchenLicenceRepository:GenericRepository<KitchenLicence>,IKitchenLicenceRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public KitchenLicenceRepository(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
