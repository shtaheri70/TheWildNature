using Microsoft.EntityFrameworkCore;
using TheWildNature.Application.Contracts.Repositories.KitchenRepository;
using TheWildNature.Application.Generator;
using TheWildNature.Domain.Entities.Kitchen;
using TheWildNature.Domain.Entities.Users;
using TheWildNature.Persintence.Context;

namespace TheWildNature.Persintence.Repositories.KitchenRepository
{
    public class KitchenRepository : GenericRepository<Kitchen>,IKitchenRepository
    {
        private readonly TheWildNatureDbContext _dbContext;
        public KitchenRepository(TheWildNatureDbContext dbContext)
            : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddBasicInformationAsync(Kitchen kitchenVM)
        {
            var newKitchen = new Kitchen
            {
                KitchenName = kitchenVM.KitchenName,
                CityId = kitchenVM.CityId,
                BusinessTypeId = kitchenVM.BusinessTypeId,
                KitchenManager = new KitchenManager
                {
                    User = new User
                    {
                        Mobile = kitchenVM.KitchenManager.User.Mobile,
                        Name = kitchenVM.KitchenManager.User.Name,
                        Family = kitchenVM.KitchenManager.User.Family,
                        ActiveCode = NameGenerator.GenerateUniqCode(),
                        IsActive = false,
                    }
                }
            };

            newKitchen = await AddAsync(newKitchen);

            return newKitchen.KitchenManager.User.ActiveCode;
        }
     
        public async Task<Kitchen> GetKitchenAndKitchenManagerInfoWithUserId(int userId)
        {
            var kitchenInfo = await _dbContext.Kitchens
                                                .Include(k => k.BusinessType)
                                                .Include(p => p.PlaceDetails)
                                                .Include(c => c.City)
                                                .Include(km => km.KitchenManager)
                                                .ThenInclude(u => u.User)
                                                .FirstOrDefaultAsync(k => k.KitchenManager.UserId == userId);

            return kitchenInfo;
        }

        public async Task<Kitchen> UpdateKitchenAndManagerInoAsync(Kitchen kitchen)
        {
            kitchen.KitchenManager = kitchen.KitchenManager;
            await UpdateAsync(kitchen);
            return await GetKitchenAndKitchenManagerInfoWithUserId(kitchen.KitchenManager.UserId);
        }
    }
}
