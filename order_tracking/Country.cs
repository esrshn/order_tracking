using System.ComponentModel.DataAnnotations;

namespace order_tracking
{
    public class Country
    {
        [Key]
        public Guid CountryId { get; set; }
        public string CountryName { get; set; }
        
       
    }
}
