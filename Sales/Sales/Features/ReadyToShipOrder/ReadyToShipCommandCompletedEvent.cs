namespace Sales.Features.ReadyToShipOrder
{
    using Commons;
    using MediatR;
    using System;

    public class ReadyToShipCommandCompletedEvent : ICommand , IRequest<string>
    {
        public Guid OrderId { get; set; }
    }
}
