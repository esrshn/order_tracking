using System.ComponentModel.DataAnnotations;

namespace order_tracking
{
    public class Contact
    {
        [Key]
        public Guid ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  int Phone {  get; set; }
        public string TCKN { get; set; }
        public bool Gender { get; set; }
      
    }
}
