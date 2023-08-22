using TheWildNature.Application.Dtos.Common;

namespace TheWildNature.Application.Dtos.Kitchen.BussinesType
{
    public class BussinessTypeDto:BaseDto,IBussinessTypeDto
    {
        public string BusinessTypeTitle { get; set; }
    }
}
