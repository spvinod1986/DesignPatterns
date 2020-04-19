using System.Collections.Generic;
using System.Linq;

namespace Command
{
    public class InvoiceService
    {
        private readonly List<Product> _products;
        public int TotalCountofProducts => _products.Count;

        public decimal TotalPrice => _products.Select(p => p.Price).Sum();

        public InvoiceService()
        {
            _products = new List<Product>();
        }

        public void AddProductToInvoice(Product product)
        {
            _products.Add(product);
            System.Console.WriteLine($"Product {product.Name} is added to invoice");
        }

        public void RemoveProductFromInvoice(Product product)
        {
            _products.Remove(product);
            System.Console.WriteLine($"Product {product.Name} is removed from invoice");
        }
    }
}