namespace Sales.Features.ReadyToShipOrder
{
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class OrderReadyToShipCompletedHandler : IRequestHandler<ReadyToShipCommandCompletedEvent, string>
    {

        public Task<string> Handle(ReadyToShipCommandCompletedEvent request, CancellationToken cancellationToken)
        {
            return default;
        }
    }
}
