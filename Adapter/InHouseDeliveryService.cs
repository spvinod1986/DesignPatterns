namespace Adapter
{
    public class InHouseDeliveryService : IDeliveryService
    {
        public void ShipOrder(Order order)
        {
            System.Console.WriteLine($"Your order for {order.ProductName} is shipped using InHouseDelivery");
        }
    }
}