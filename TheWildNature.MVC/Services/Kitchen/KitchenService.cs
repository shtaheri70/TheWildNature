using AutoMapper;
using TheWildNature.MVC.Contracts;
using TheWildNature.MVC.Contracts.Kitchen;
using TheWildNature.MVC.Models.Kitchen;
using TheWildNature.MVC.Services.Base;

namespace TheWildNature.MVC.Services.Kitchen
{
    public class KitchenService : BaseHttpSrvice, IKitchenService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IClient _httpClient;
        private readonly IMapper _mappert;
        public KitchenService(IMapper mapper,IClient client, ILocalStorageService localStorage)
            : base(client, localStorage)
        {
            _mappert = mapper;
            _httpClient = client;
            _localStorage = localStorage;
        }
        public async Task<Response<int>> AddBasicInformationAsync(CreateKitchenBaiscInfoVM kitchen)
        {
            try 
            {
                var response = new Response<int>();
                CreateKitchenBaiscInfoDto kitchenBaiscInfoDto = 
                    _mappert.Map<CreateKitchenBaiscInfoDto>(kitchen);

                //TODO Authen
                var apiResponse = await _httpClient.RegisterBasicInfoAsync(kitchenBaiscInfoDto);

                if (apiResponse.Success)
                {
                    response.Data = apiResponse.Id;
                    response.Success = true;
                }
                else
                {
                    foreach (var err in apiResponse.Errors)
                    {
                        response.ValidationErrors += err + Environment.NewLine;
                    }
                }
                return response;
            }
            catch(ApiException ex)
            {
                return ConverApiException<int>(ex);
            }
        }
    }
}
