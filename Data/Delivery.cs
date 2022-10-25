namespace MyBakery.Data
{
    public class Delivery
    {
        public int OrderNum { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }

        public DateTime DeliveryDate { get; set; }
    }
}
