using Microsoft.AspNetCore.Http;
using TheWildNature.Application.Dtos.Common;

namespace TheWildNature.Application.Dtos.Kitchen.FinancialInfo
{
    public class EditKitchenFinancialInfoDto :BaseDto, IKitchenFinancialInfoDto
    {
        public int AccountNumber { get; set; }
        public int CardNumber { get; set; }
        public string ShabaNumber { get; set; }
        public string BankName { get; set; }
        public string CardFileName { get; set; }
        public string BusinessLicenseFileName { get; set; }
        public IFormFile CardFile { get; set; }
        public IFormFile BusinessLicenseFile { get; set; }
    }
}
