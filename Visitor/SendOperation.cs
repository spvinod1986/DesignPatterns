namespace Visitor
{
    public class SendOperation : IOperation
    {
        public void apply(EmailNotification notification)
        {
            System.Console.WriteLine($"Email notification is sent to the user to email address {notification.EmailAddress}");
        }

        public void apply(BannerNotification notification)
        {
            System.Console.WriteLine($"Banner notification is sent to the user phone {notification.PhoneModel}");
        }

        public void apply(SmsNotification notification)
        {
            System.Console.WriteLine($"SMS notification is sent to the user phone number {notification.PhoneNumber}");
        }
    }
}