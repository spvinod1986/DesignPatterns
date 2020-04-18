namespace Strategy
{
    public class FedExDeliveryProvider : IDeliveryProvider
    {
        public void ProcessDelivery(Item item, string address)
        {
            System.Console.WriteLine($"Item {item.Name} will be delivered to your address by FedEx");
        }
    }
}