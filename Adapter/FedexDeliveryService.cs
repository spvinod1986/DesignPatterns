using Fedex;

namespace Adapter
{
    // This is adapter for Fedex
    public class FedexDeliveryService : IDeliveryService
    {
        private readonly FedexService service;
        public FedexDeliveryService()
        {
            service = new FedexService();
        }
        public void ShipOrder(Order order)
        {
            service.CreateShipment(order.Address, order.ProductName);
        }
    }
}