using System;

namespace Mediator
{
    public class LocationFilter
    {
        public event EventHandler LocationUpdated;
        public void UpdateFilter()
        {
            System.Console.WriteLine($"Location Filter updated to display related locations");
            LocationUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}