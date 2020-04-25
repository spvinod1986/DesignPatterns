namespace Visitor
{
    public interface IOperation
    {
        void apply(EmailNotification notification);
        void apply(BannerNotification notification);
        void apply(SmsNotification notification);
    }
}