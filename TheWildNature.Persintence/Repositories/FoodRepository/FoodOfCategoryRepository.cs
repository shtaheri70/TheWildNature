using TheWildNature.Application.Contracts.Repositories.FoodRepository;
using TheWildNature.Domain.Entities.Food;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.FoodRepository
{
    public class FoodOfCategoryRepository : GenericRepository<FoodCategory>,IFoodOfCategoryRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public FoodOfCategoryRepository(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }

}
