using System.ComponentModel.DataAnnotations;

namespace order_tracking
{
    public class District
    {
        [Key]
        public Guid DistrictId { get; set; }
        public int DistrictNumber { get; set; }
        public string DistrictName { get; set; }
        public int CountyId { get; set; }

    }
}