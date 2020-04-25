namespace Visitor
{
    public class BannerNotification : INotification
    {
        public string PhoneModel { get; private set; }
        public BannerNotification(string phoneModel)
        {
            PhoneModel = phoneModel;
        }
        public void Execute(IOperation operation)
        {
            operation.apply(this);
        }
    }
}