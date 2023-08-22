using TheWildNature.MVC.Models.Kitchen;
using TheWildNature.MVC.Services.Base;

namespace TheWildNature.MVC.Contracts.Kitchen
{
    public interface IKitchenService
    {
        Task<Response<int> > AddBasicInformationAsync(CreateKitchenBaiscInfoVM kitchen);
    }
}
