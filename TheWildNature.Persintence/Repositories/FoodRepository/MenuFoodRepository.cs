using TheWildNature.Application.Contracts.Repositories.FoodRepository;
using TheWildNature.Domain.Entities.Food;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.FoodRepository
{
    public class MenuFoodRepository:GenericRepository<MenuFood>,IMenuFoodRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public MenuFoodRepository(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
