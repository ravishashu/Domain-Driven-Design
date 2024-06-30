using Infrastructure.Repositories;
using Application.Services;

var orderRepository = new OrderRepository();
var orderService = new OrderService(orderRepository);

orderService.CreateOrder();

var orderId = orderRepository.GetById(Guid.NewGuid()).OrderId;
orderService.PrintOrderTotal(orderId);

Console.ReadLine();
