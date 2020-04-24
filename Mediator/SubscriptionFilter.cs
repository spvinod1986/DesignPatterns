using System;

namespace Mediator
{
    public class SubscriptionFilter
    {
        public event EventHandler SubscriptionUpdated;
        public void UpdateFilter()
        {
            System.Console.WriteLine($"Subscription Filter updated to display related Subscriptions");
            SubscriptionUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}