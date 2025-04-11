using System.ComponentModel.DataAnnotations;

namespace order_tracking
{
    public class City
    {
        [Key]
        public Guid CityId { get; set; }
        public int CityNumber { get; set; }

        public string CityName { get; set; }
        public Guid CountryId { get; set; }



    }
}
