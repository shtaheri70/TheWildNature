using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Domain.Entities.Kitchen;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.KitchenRepository
{
    public class KitchenFinancialInfoRepository:GenericRepository<KitchenFinancialInfo>,IKitchenFinancialInfoRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public KitchenFinancialInfoRepository(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
