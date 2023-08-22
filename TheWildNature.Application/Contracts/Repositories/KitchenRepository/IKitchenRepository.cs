using TheWildNature.Application.Dtos.Kitchen;
using TheWildNature.Domain.Entities.Kitchen;

namespace TheWildNature.Application.Contracts.Repositories.KitchenRepository
{
    public interface IKitchenRepository:IGenericRepository<Kitchen>
    {
        Task<String> AddBasicInformationAsync(Kitchen kitchen);
        Task<Kitchen> GetKitchenAndKitchenManagerInfoWithUserId(int userId);
        Task<Kitchen> UpdateKitchenAndManagerInoAsync(Kitchen kitchen);
    }
}
