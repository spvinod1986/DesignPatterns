namespace Strategy
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}