using System;

namespace Observer
{
    public class ProductAddedEventArgs : EventArgs
    {
        public Product Product { get; private set; }
        public ProductAddedEventArgs(Product product)
        {
            Product = product;
        }
    }
}