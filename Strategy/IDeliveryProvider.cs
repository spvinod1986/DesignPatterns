namespace Strategy
{
    public interface IDeliveryProvider
    {
        void ProcessDelivery(Item item, string address);
    }
}