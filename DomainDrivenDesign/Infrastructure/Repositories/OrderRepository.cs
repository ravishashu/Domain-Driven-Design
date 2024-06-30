using Domain.Entities;
using Domain.Repositories;


namespace Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new List<Order>();

        public void Add(Order order)
        {
            _orders.Add(order);
        }

        public Order GetById(Guid orderId)
        {
            return _orders.FirstOrDefault(o => o.OrderId == orderId);
        }

        public void Save(Order order)
        {
            var existingOrder = GetById(order.OrderId);
            if (existingOrder != null)
            {
                _orders.Remove(existingOrder);
                _orders.Add(order);
            }
        }
    }
}
