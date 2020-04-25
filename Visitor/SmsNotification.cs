namespace Visitor
{
    public class SmsNotification : INotification
    {
        public string PhoneNumber { get; private set; }
        public SmsNotification(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }
        public void Execute(IOperation operation)
        {
            operation.apply(this);
        }
    }
}