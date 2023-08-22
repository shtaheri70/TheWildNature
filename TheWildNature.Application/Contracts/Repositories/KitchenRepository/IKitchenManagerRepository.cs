using TheWildNature.Domain.Entities.Kitchen;

namespace TheWildNature.Application.Contracts.Repositories.KitchenRepository
{
    public interface IKitchenManagerRepository : IGenericRepository<KitchenManager>
    {
        public Task<KitchenManager> GetKitchenManagerWithUserId(int userId);
    }
}
