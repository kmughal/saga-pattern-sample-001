namespace Sales.Contracts
{
    using System;
    using System.Threading.Tasks;

    public interface IOrderDbContenxt
    {
        Task<string> SaveOrderAsync(Order order);
        Task<Order> GetOrdersAsync(Guid orderId);
    }
}
