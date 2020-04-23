using System;
using System.Collections.Generic;

namespace Observer
{
    public class DataMiningService : IObserver<Product>
    {
        private IDisposable cancellation;
        private List<Product> products;

        public DataMiningService()
        {
            products = new List<Product>();
        }
        public void Subscribe(CartService provider)
        {
            cancellation = provider.Subscribe(this);
        }

        public void UnSubscribe()
        {
            cancellation.Dispose();
            products.Clear();
        }
        public void OnCompleted()
        {
            System.Console.WriteLine($"DataMining finalized with {products.Count} products for analysis");
            System.Console.WriteLine("Transmission ended in DataMining Service");
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Product product)
        {
            products.Add(product);
            System.Console.WriteLine($"Product {product.Name} received in DataMining Service");
        }
    }
}