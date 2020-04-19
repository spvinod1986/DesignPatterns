using System;
using System.Collections.Generic;

namespace Command
{
    public class InventoryService
    {
        public List<Product> Products { get; set; }

        public int TotalCountofProducts => Products.Count;

        public DateTime DeliveryDate => DateTime.Now.AddDays(5);
        public InventoryService()
        {
            Products = new List<Product>();
        }

        public void AddProductToDelivery(Product product)
        {
            Products.Add(product);
            System.Console.WriteLine($"Product {product.Name} is added to delivery schedule");
        }

        public void RemoveProductFromDelivery(Product product)
        {
            Products.Remove(product);
            System.Console.WriteLine($"Product {product.Name} is removed from delivery schedule");
        }
    }
}