using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Domain.Entities.Kitchen;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.KitchenRepository
{
    public class BussinessTypeRepository:GenericRepository<BusinessType>,IBussinessTypeRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public BussinessTypeRepository(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
