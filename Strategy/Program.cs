using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderService = new OrderService(new CreditCardPaymentProcessor(), new FedExDeliveryProvider());
            orderService.BuyOnline(new Item { Name = "Book", Price = 10.00m }, "TestAddress");

            orderService = new OrderService(new ApplePaymentProcessor(), new USPSDeliveryProvider());
            orderService.BuyOnline(new Item { Name = "Soap", Price = 10.00m }, "TestAddress");
        }
    }
}
