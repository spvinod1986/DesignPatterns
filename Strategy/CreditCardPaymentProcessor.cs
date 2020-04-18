namespace Strategy
{
    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            System.Console.WriteLine($"Amount {amount} paid through Credit Card");
        }
    }
}