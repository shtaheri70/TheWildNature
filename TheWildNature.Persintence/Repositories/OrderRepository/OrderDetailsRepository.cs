using TheWildNature.Application.Contracts.Repositories.OrderRepository;
using TheWildNature.Domain.Entities.Customer;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.OrderRepository
{
   public class OrderDetailsRepository:GenericRepository<OrderDetails>,IOrderDetailsRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public OrderDetailsRepository(TheWildNatureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
