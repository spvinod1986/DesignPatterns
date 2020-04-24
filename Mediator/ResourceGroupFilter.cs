using System;

namespace Mediator
{
    public class ResourceGroupFilter
    {
        public event EventHandler ResourceGroupUpdated;
        public void UpdateFilter()
        {
            System.Console.WriteLine($"ResourceGroup Filter updated to display related ResourceGroups");
            ResourceGroupUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}