using TheWildNature.Application.Dtos.Common;

namespace TheWildNature.Application.Dtos.Kitchen
{
    public class KitchenDto:BaseDto,IKitchenDto
    {
        public string KitchenName { get; set; }
        public bool exclusiveDelivery { get; set; }
        public int NumberBranche { get; set; }
        public int BusinessTypeId { get; set; }

    }
}
