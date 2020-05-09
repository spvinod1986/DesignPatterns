using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code without using proxy
            // var context = new ProductContext();
            // var product = context.Get(1);
            // product.Name = "UpdatedProduct";
            // context.MarkProductAsChanged(product);
            // context.SaveChanges();

            // Code using proxy
            var context = new ProductContext();
            var product = context.Get(1);
            product.Name = "UpdatedSecondTimeProduct";
            context.SaveChanges();

        }
    }
}
