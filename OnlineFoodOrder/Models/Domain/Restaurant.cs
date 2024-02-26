namespace OnlineFoodOrder.Models.Domain
{
    public class Restaurant
    {

        public Guid Id { get; set; }
        public string RestaurantName {  get; set; }
        public string Address {  get; set; }
        public string Landmark {  get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }


        public List<Customer> Customers { get; set; }
    }
}
