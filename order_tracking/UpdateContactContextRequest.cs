namespace order_tracking.Models
{
    public class UpdateContactRequest
    {
        public int ContactId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string TCKN { get; set; }

        public bool Gender { get; set; }
    }
}
