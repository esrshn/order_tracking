using System.ComponentModel.DataAnnotations;

namespace order_tracking
{
    public class Address
    {
        [Key]
        public Guid AddressId { get; set; }
        
        public Guid ContactId { get; set; }
        public Guid CityId { get; set; }
        public Guid CountryId { get; set; }
        public Guid CountyId { get; set; }
        public Guid DistrictId { get; set; }



        


    }
}
