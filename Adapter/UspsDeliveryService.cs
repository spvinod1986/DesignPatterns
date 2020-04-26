using Usps;

namespace Adapter
{
    // This is adapter for USPS
    public class UspsDeliveryService : IDeliveryService
    {
        private readonly UspsService service;
        public UspsDeliveryService()
        {
            service = new UspsService();
        }
        public void ShipOrder(Order order)
        {
            service.CreateAndShipPackage(order.Address);
        }
    }
}