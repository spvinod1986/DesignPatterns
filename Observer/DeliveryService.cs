using System;
using System.Collections.Generic;

namespace Observer
{
    public class DeliveryService
    {
        private List<Product> products;

        public DeliveryService()
        {
            products = new List<Product>();
        }

        public void HandleProductAdded(object sender, ProductAddedEventArgs args)
        {
            products.Add(args.Product);
            System.Console.WriteLine($"Product {args.Product} received in Delivery Service");
        }
    }
}