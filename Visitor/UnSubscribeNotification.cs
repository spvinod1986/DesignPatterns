namespace Visitor
{
    public class UnSubscribeOperation : IOperation
    {
        public void apply(EmailNotification notification)
        {
            System.Console.WriteLine($"User email address {notification.EmailAddress} UnSubscribed to Email notification");
        }

        public void apply(BannerNotification notification)
        {
            System.Console.WriteLine($"User {notification.PhoneModel} UnSubscribed to banner notification");
        }

        public void apply(SmsNotification notification)
        {
            System.Console.WriteLine($"User phone number {notification.PhoneNumber} UnSubscribed to SMS notification");
        }
    }
}