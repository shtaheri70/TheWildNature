namespace TheWildNature.Application.Dtos.PlaceDetails
{
    public interface IPlaceDetailsDto
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string AddressDetails { get; set; }
        public string Phone { get; set; }
    }
}
