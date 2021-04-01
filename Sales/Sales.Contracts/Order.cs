namespace Sales.Contracts
{
    using System;


    public class Order
    {
        private readonly Guid _orderId;

        public Guid OrderId
        {
            get => _orderId;
            init => _orderId = value;
        }

        public OrderStatus Status { get; set; }
    }
}
