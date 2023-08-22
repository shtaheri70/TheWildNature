using Microsoft.AspNetCore.Http;

namespace TheWildNature.Application.Dtos.Kitchen.FinancialInfo
{
    public class CreateKitchenFinancialInfoDto : IKitchenFinancialInfoDto
    {
        public int AccountNumber { get; set; }
        public int CardNumber { get; set; }
        public string ShabaNumber { get; set; }
        public string BankName { get; set; }
       
        public IFormFile CardFile { get; set; }
        public IFormFile BusinessLicenseFile { get; set; }
    }
}
