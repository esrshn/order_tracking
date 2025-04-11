using System.ComponentModel.DataAnnotations;

namespace order_tracking
{
    public class Return
    {
        [Key]
        
        public Guid ReturnId { get; set; }
        public string RetrunNumber { get; set; }
        public Guid OrderId { get; set; }


    }
}
