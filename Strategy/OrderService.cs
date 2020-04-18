using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    public class OrderService
    {
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IDeliveryProvider _deliveryProvider;
        public OrderService(IPaymentProcessor paymentProcessor, IDeliveryProvider deliveryProvider)
        {
            _paymentProcessor = paymentProcessor;
            _deliveryProvider = deliveryProvider;
        }

        public void BuyOnline(Item item, string deliveryAddress)
        {
            _paymentProcessor.ProcessPayment(item.Price);
            _deliveryProvider.ProcessDelivery(item, deliveryAddress);
        }
    }
}