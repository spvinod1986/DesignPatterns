namespace Strategy
{
    public class ApplePaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            System.Console.WriteLine($"Amount {amount} paid through ApplePay");
        }
    }
}