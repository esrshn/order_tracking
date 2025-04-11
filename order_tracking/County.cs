using System.ComponentModel.DataAnnotations;

namespace order_tracking
{
    public class County
    {
        [Key]
        public Guid CountyId { get; set; }
        public string CountyName { get; set; }
        public int CountyNumber { get; set; }
        public Guid CityId { get; set; }


    }
}
