using System.Collections.Generic;

namespace Visitor
{
    public class UserProfile
    {
        private List<INotification> notifications = new List<INotification>();

        public void AddNotificationPreference(INotification notification)
        {
            notifications.Add(notification);
        }

        public void NotifyCommand(IOperation operation)
        {
            foreach (var notification in notifications)
            {
                notification.Execute(operation);
            }
        }
    }
}