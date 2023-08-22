namespace TheWildNature.Application.Dtos.City
{
    public class CreateCityDto:ICityDto
    {
        public int ProvinceId { get; set; }
        public string CityName { get; set; }
    }
}
