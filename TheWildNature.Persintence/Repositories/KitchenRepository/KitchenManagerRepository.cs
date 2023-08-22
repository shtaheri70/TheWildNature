using Microsoft.EntityFrameworkCore;
using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Domain.Entities.Kitchen;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.KitchenRepository
{
    public class KitchenManagerRepository : GenericRepository<KitchenManager>,IKitchenManagerRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public KitchenManagerRepository(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<KitchenManager> GetKitchenManagerWithUserId(int userId)
        {
          return  await _dbContext.KitchenManagers.FirstOrDefaultAsync(k=> k.UserId == userId);
        }
    }
}
