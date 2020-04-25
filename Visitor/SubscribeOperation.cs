namespace Visitor
{
    public class SubscribeOperation : IOperation
    {
        public void apply(EmailNotification notification)
        {
            System.Console.WriteLine($"User email address {notification.EmailAddress} subscribed to Email notification");
        }

        public void apply(BannerNotification notification)
        {
            System.Console.WriteLine($"User {notification.PhoneModel} subscribed to banner notification");
        }

        public void apply(SmsNotification notification)
        {
            System.Console.WriteLine($"User phone number {notification.PhoneNumber} subscribed to SMS notification");
        }
    }
}