using System.ComponentModel.DataAnnotations;

namespace order_tracking
{
    public class Order
    {
        [Key]
        
        public Guid  OrderId {  get; set; }
        public string OrderNumber { get; set; }
        public Guid ContactId { get; set; }
        public int OrderAmount { get; set; }

  

    }
}
