
using TheWildNature.Domain.Entities.Commons;

namespace TheWildNature.Domain.Entities.City
{
    public class Province: BaseDomainEntity
    {
        public string Name { get; set; }

        #region  Navigation Property
        public  List<City> Cities { get; set; }
        #endregion
    }

}