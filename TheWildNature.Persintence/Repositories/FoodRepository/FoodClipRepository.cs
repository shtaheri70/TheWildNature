using TheWildNature.Application.Contracts.Repositories.FoodRepository;
using TheWildNature.Domain.Entities.Food;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.FoodRepository
{
    public class FoodClipRepository:GenericRepository<FoodClip>,IFoodClipRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public FoodClipRepository(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
