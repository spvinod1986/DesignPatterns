using System;
using System.Collections.Generic;

namespace Observer
{
    public class NotificationService : IObserver<Product>
    {
        private IDisposable cancellation;
        private List<Product> products;

        public NotificationService()
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
            System.Console.WriteLine("Transmission ended in Notification Service");
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Product product)
        {
            products.Add(product);
            System.Console.WriteLine($"Product {product.Name} received in Notification Service");
        }
    }
}