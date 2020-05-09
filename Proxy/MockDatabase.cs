using System.Collections.Generic;
using System.Linq;

namespace Proxy
{
    public class MockDatabase
    {
        // This class mocks real database for demo purpose
        private readonly List<Product> _products;
        public MockDatabase()
        {
            _products = new List<Product>();

            _products.Add(new Product { Id = 1, Name = "Product1", Description = "ProductDescription1", Price = 10.00m });
            _products.Add(new Product { Id = 2, Name = "Product2", Description = "ProductDescription2", Price = 20.00m });
            _products.Add(new Product { Id = 3, Name = "Product3", Description = "ProductDescription3", Price = 30.00m });
        }

        public List<Product> Products
        {
            get
            {
                System.Console.WriteLine($"Executing SQL to get all {_products.Count} product rows");
                return _products;
            }
        }

        public Product Select(int id)
        {
            System.Console.WriteLine($"Executing SQL to select one product row");
            return _products.Where(p => p.Id == id).FirstOrDefault();
        }

        public void Update(Product product)
        {
            System.Console.WriteLine($"Executing SQL to update one product row");
            _products.Remove(product);
            _products.Add(product);
        }
    }
}