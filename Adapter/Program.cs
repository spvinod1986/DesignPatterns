using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart1 = new Cart("Soap", "Address1");
            cart1.Buy(new InHouseDeliveryService());

            var cart2 = new Cart("Food", "Address2");
            cart2.Buy(new FedexDeliveryService());

            var cart3 = new Cart("Alcohol", "Address3");
            cart3.Buy(new UspsDeliveryService());
        }
    }
}
