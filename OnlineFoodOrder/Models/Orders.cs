namespace OnlineFoodOrder.Models
{
    public class Orders
    {
        public int OrdersId { get; set; }
        public string OrdersName { get; set; }
        public bool IsCheck { get; set; }

    }

    public class OrderList
    {
        public List<Orders> Ord { get; set; }
    }
}
