using TheWildNature.Application.Models;

namespace TheWildNature.Application.Contracts.Infrastructure
{
    public interface ISMSSender
    {
        Task SendPublicSMS(string phoneNumber, string message);

        Task SendLookupSMS(string phoneNumber, string templateName, string token);
    }
}
