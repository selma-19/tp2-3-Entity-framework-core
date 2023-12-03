namespace tp2.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public float SignUpFee { get; set; }
        public int DurationInMonth { get; set; }
        public float DiscountRate { get; set; }

        public ICollection<Customer>? Customers { get; set; }

    }
}
