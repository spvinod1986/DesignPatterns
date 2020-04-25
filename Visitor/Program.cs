using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var userProfile = new UserProfile();
            userProfile.AddNotificationPreference(new EmailNotification("abc@gmail.com"));
            userProfile.AddNotificationPreference(new SmsNotification("444-555-666"));
            userProfile.NotifyCommand(new SubscribeOperation());
            userProfile.NotifyCommand(new SendOperation());
            userProfile.NotifyCommand(new UnSubscribeOperation());
        }
    }
}
