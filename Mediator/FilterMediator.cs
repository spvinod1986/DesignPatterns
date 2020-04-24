using System;

namespace Mediator
{
    public class FilterMediator
    {
        private SubscriptionFilter subscription = new SubscriptionFilter();
        private ResourceGroupFilter resourceGroup = new ResourceGroupFilter();
        private LocationFilter location = new LocationFilter();

        private Chart chart = new Chart();

        public FilterMediator()
        {
            subscription.SubscriptionUpdated += SubscriptionUpdated;
            resourceGroup.ResourceGroupUpdated += ResourceGroupUpdated;
            location.LocationUpdated += LocationUpdated;
        }

        public void ChangeFilter()
        {
            System.Console.WriteLine("Filter value changed in UI");
            subscription.UpdateFilter();
        }
        private void SubscriptionUpdated(object sender, EventArgs args)
        {
            resourceGroup.UpdateFilter();
        }

        private void ResourceGroupUpdated(object sender, EventArgs args)
        {
            location.UpdateFilter();
        }

        private void LocationUpdated(object sender, EventArgs args)
        {
            chart.UpdateChart();
        }
    }
}