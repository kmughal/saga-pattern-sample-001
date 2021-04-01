namespace Sales.Features.ReadyToShipOrder
{
    using Commons;
    using MediatR;
    using System;

    public class ReadyToShipOrderCommand : ICommand , IRequest<string>
    {
        public Guid OrderId { get; set; }
    }
}
