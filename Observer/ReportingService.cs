using System;
using System.Collections.Generic;

namespace Observer
{
    public class ReportingService
    {
        private List<Product> products;

        public ReportingService()
        {
            products = new List<Product>();
        }

        public void HandleProductAdded(object sender, ProductAddedEventArgs args)
        {
            products.Add(args.Product);
            System.Console.WriteLine($"Product {args.Product.Name} received in Reporting Service");
        }
    }
}