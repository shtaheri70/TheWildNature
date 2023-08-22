using TheWildNature.Application.Contracts.Repositories.OrderRepository;
using TheWildNature.Domain.Entities.Customer;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.OrderRepository
{
    public class OrderStatusRepository:GenericRepository<OrderStatus>,IOrderStatusRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public OrderStatusRepository(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
