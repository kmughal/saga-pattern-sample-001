namespace Sales.Features.ReadyToShipOrder
{
    using MediatR;
    using Sales.Contracts;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReadyToShipOrderCommandHandler : IRequestHandler<ReadyToShipOrderCommand, string>
    {
        private readonly IOrderDbContenxt _orderDbContenxt;

        public ReadyToShipOrderCommandHandler(IOrderDbContenxt orderDbContenxt) => _orderDbContenxt = orderDbContenxt;

        public async Task<string> Handle(ReadyToShipOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _orderDbContenxt.GetOrdersAsync(request.OrderId);
            if (order is null) throw new ArgumentNullException("Fail to find the order!");
            order.Status = OrderStatus.Ready;

            var result = await _orderDbContenxt.SaveOrderAsync(order);
            return result;
        }
    }
}

