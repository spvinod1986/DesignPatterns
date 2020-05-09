using System.Collections.Generic;
using System.Linq;

namespace Proxy
{
    public class ProductContext
    {
        private Dictionary<int, Product> updatedProducts;
        private readonly MockDatabase _db;
        public ProductContext()
        {
            _db = new MockDatabase();
            updatedProducts = new Dictionary<int, Product>();
        }

        public Product Get(int id)
        {
            // System.Console.WriteLine($"Establishing connection and Generating SQL to get one product row");
            // Lazy loading
            return new ProductProxy(id, this);
        }

        public void MarkProductAsChanged(Product product)
        {
            System.Console.WriteLine($"Establishing connection and Generating SQL to update one product row");
            updatedProducts.Add(product.Id, product);
        }

        public void SaveChanges()
        {
            foreach (var product in updatedProducts)
            {
                _db.Update(product.Value);
            }
        }

    }
}