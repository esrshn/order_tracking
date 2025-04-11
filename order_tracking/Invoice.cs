using System.ComponentModel.DataAnnotations;

namespace order_tracking
{
    public class Invoice
    {
        [Key]
        
        public Guid InvoiceId {  get; set; }
        public  string InvoiceNumber { get; set; }
        public Guid OrderId { get; set; }



    }
}
