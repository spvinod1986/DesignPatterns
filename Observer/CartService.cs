using System;
using System.Collections.Generic;

namespace Observer
{
    public class CartService : IObservable<Product>
    {
        private List<Product> products;
        private List<IObserver<Product>> observers;
        public event EventHandler<ProductAddedEventArgs> ProductAdded;

        public CartService()
        {
            products = new List<Product>();
            observers = new List<IObserver<Product>>();
        }
        public void AddItem(Product product)
        {
            products.Add(product);
            System.Console.WriteLine($"Product {product.Name} added to Cart");

            // Option 1 : Using IObserver/IObservable pattern
            foreach (var observer in observers)
            {
                observer.OnNext(product);
            }

            // Option 2: Using Event Handler Pattern
            ProductAdded?.Invoke(this, new ProductAddedEventArgs(product));
        }

        public void Buy()
        {
            System.Console.WriteLine($"Cart finalized with {products.Count} products");
            TransimissionComplete();
        }

        public IDisposable Subscribe(IObserver<Product> observer)
        {
            // Register if not already registered
            if (!observers.Contains(observer))
            {
                observers.Add(observer);

                // Send the existing item in cart
                foreach (var product in products)
                {
                    observer.OnNext(product);
                }
            }
            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private readonly List<IObserver<Product>> _observers;
            private readonly IObserver<Product> _observer;
            public Unsubscriber(List<IObserver<Product>> observers, IObserver<Product> observer)
            {
                _observers = observers;
                _observer = observer;
            }
            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void TransimissionComplete()
        {
            System.Console.WriteLine("Cart Service is ending transmission");
            foreach (var observer in observers)
            {
                observer.OnCompleted();
            }

            observers.Clear();
        }
    }
}