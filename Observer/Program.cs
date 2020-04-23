using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Option 1 : Using IObservable/IObserver pattern (.NET)
            // Create those interfaces if not available in framework
            var cart1 = new CartService();
            var dataminingObserver = new DataMiningService();
            var notificationObserver = new NotificationService();

            dataminingObserver.Subscribe(cart1);
            cart1.AddItem(new Product { Name = "Bottle" });
            notificationObserver.Subscribe(cart1);
            cart1.AddItem(new Product { Name = "Cookies" });
            dataminingObserver.UnSubscribe();
            cart1.AddItem(new Product { Name = "Water" });
            cart1.Buy();

            // Option 2 : Using EventHandler/Delegate
            var cart2 = new CartService();
            var reportingObserver = new ReportingService();
            var deliveryObserver = new ReportingService();

            cart2.ProductAdded += reportingObserver.HandleProductAdded;
            cart2.AddItem(new Product { Name = "Wine" });
            cart2.ProductAdded += deliveryObserver.HandleProductAdded;
            cart2.AddItem(new Product { Name = "Beer" });
            cart2.ProductAdded -= deliveryObserver.HandleProductAdded;
            cart2.AddItem(new Product { Name = "Cocktail" });
            cart2.Buy();

        }
    }
}
