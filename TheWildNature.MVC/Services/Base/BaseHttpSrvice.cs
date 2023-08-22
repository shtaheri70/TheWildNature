using System.Net.Http.Headers;
using TheWildNature.MVC.Contracts;

namespace TheWildNature.MVC.Services.Base
{
    public class BaseHttpSrvice
    {
        protected readonly ILocalStorageService _localStorage;
        protected readonly IClient _client;

        public BaseHttpSrvice(IClient client, ILocalStorageService localStorage)
        {
            _client = client;
            _localStorage = localStorage;

        }

        protected Response<Guid> ConverApiException<Guid>(ApiException exception)
        {
            switch (exception.StatusCode)
            {
                case 400:
                    return new Response<Guid>()
                    {
                        Message = "Validation errors have occared...",
                        ValidationErrors = exception.Response,
                        Success = false
                    };
                    break;
                case 404:
                    return new Response<Guid>()
                    {
                        Message = "Not found...",
                        Success = false
                    };
                    break;
                default:
                    return new Response<Guid>()
                    {
                        Message = "Somthing went wrong, try again...",
                        Success = false
                    };
                    break;
            }
        }
        protected void AddBerarerToken()
        {
            if (_localStorage.Exists("token"))
            {
                _client.HttpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", _localStorage.GetStorageValue<string>("token"));
            }
        }
    }
}
