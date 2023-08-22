using Microsoft.Extensions.Options;
using TheWildNature.Application.Contracts.Infrastructure;
using TheWildNature.Application.Models;

namespace TheWildNature.Infrastructure.Sender.SMS
{
    public class SMSSender : ISMSSender
    {
        private readonly Application.Models.KavenegarSetting _kavenegarSetting;

        public SMSSender(IOptions<Application.Models.KavenegarSetting> kavenegarSetting)
        {
            _kavenegarSetting = kavenegarSetting.Value;
        }

        public async Task SendPublicSMS(string phoneNumber, string message)
        {
            try
            {
                var api = new Kavenegar.KavenegarApi(_kavenegarSetting.ApiKey);

                var result = await api.Send(_kavenegarSetting.Sender, phoneNumber, message);
            }
            catch (Kavenegar.Core.Exceptions.ApiException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Kavenegar.Core.Exceptions.HttpException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task SendLookupSMS(string phoneNumber, string templateName, string token)
        {
            try
            {
                var api = new Kavenegar.KavenegarApi(_kavenegarSetting.ApiKey);

                var result = await api.VerifyLookup(phoneNumber, token, "", "", templateName);
            }
            catch (Kavenegar.Core.Exceptions.ApiException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Kavenegar.Core.Exceptions.HttpException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
