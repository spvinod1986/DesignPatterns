using System.Collections.Generic;
using System.Linq;

namespace Command
{
    public class InvoiceService
    {
        public List<Product> Products { get; set; }
        public int TotalCountofProducts => Products.Count;

        public decimal TotalPrice => Products.Select(p => p.Price).Sum();

        public InvoiceService()
        {
            Products = new List<Product>();
        }

        public void AddProductToInvoice(Product product)
        {
            Products.Add(product);
            System.Console.WriteLine($"Product {product.Name} is added to invoice");
        }

        public void RemoveProductFromInvoice(Product product)
        {
            Products.Remove(product);
            System.Console.WriteLine($"Product {product.Name} is removed from invoice");
        }
    }
}