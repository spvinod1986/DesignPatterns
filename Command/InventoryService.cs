using System;
using System.Collections.Generic;

namespace Command
{
    public class InventoryService
    {
        private readonly List<Product> _products;

        public int TotalCountofProducts => _products.Count;

        public DateTime DeliveryDate => DateTime.Now.AddDays(5);
        public InventoryService()
        {
            _products = new List<Product>();
        }

        public void AddProductToDelivery(Product product)
        {
            _products.Add(product);
            System.Console.WriteLine($"Product {product.Name} is added to delivery schedule");
        }

        public void RemoveProductFromDelivery(Product product)
        {
            _products.Remove(product);
            System.Console.WriteLine($"Product {product.Name} is removed from delivery schedule");
        }
    }
}