using TheWildNature.Application.Contracts.Repositories.FoodRepository;
using TheWildNature.Domain.Entities.Food;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.FoodRepository
{
    public class MenuRepository:GenericRepository<Menu>,IMenuRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public MenuRepository(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
