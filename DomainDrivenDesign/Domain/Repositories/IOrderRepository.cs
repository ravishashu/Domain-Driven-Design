using Domain.Entities;

namespace Domain.Repositories
{
    public interface IOrderRepository
    {
        void Add(Order order);
        Order GetById(Guid orderId);
        void Save(Order order);
    }
}
