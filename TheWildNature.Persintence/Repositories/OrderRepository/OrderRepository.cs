using TheWildNature.Application.Contracts.Repositories.OrderRepository;
using TheWildNature.Domain.Entities.Customer;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.OrderRepository
{
    public class OrderRepository:GenericRepository<Order>,IOrderRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public OrderRepository(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
