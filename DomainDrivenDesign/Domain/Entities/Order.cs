namespace Domain.Entities
{
    public class Order
    {
        public Guid OrderId { get; private set; }
        public DateTime OrderDate { get; private set; }
        public List<OrderItem> Items { get; private set; }

        public Order()
        {
            OrderId = Guid.NewGuid();
            OrderDate = DateTime.Now;
            Items = new List<OrderItem>();
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public decimal GetTotalPrice()
        {
            return Items.Sum(item => item.Price * item.Quantity);
        }
    }
}
