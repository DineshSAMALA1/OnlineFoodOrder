namespace OnlineFoodOrder.Models.Domain
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string name {  get; set; }
        public string phone {  get; set; }
        public string email { get; set; } 
        public string Address {  get; set; }

        public Guid RestaurantId { get; set; } 
        public Restaurant restaurant { get; set; }

    }
}
