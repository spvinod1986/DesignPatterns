namespace Adapter
{
    public class Cart
    {
        private readonly string _productName;
        private readonly string _userAddress;
        public Cart(string productName, string userAddress)
        {
            _productName = productName;
            _userAddress = userAddress;
        }

        public void Buy(IDeliveryService deliveryService)
        {
            deliveryService.ShipOrder(new Order { ProductName = _productName, Address = _userAddress });
        }
    }
}