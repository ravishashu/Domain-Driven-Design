using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Repositories;
using System;

namespace Application.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void CreateOrder()
        {
            var order = new Order();
            order.AddItem(new OrderItem(Guid.NewGuid(), 2, 100));
            _orderRepository.Add(order);
        }

        public void PrintOrderTotal(Guid orderId)
        {
            var order = _orderRepository.GetById(orderId);
            if (order != null)
            {
                Console.WriteLine($"Total Price: {order.GetTotalPrice()}");
            }
        }
    }
}
