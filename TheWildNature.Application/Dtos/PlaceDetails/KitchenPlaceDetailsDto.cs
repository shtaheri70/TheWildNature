namespace TheWildNature.Application.Dtos.PlaceDetails
{
    public class KitchenPlaceDetailsDto: IPlaceDetailsDto
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string AddressDetails { get; set; }
        public string Phone { get; set; }
        public string PlaceType { get; set; }
    }
}
