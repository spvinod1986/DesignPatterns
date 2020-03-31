namespace ChainOfResponsibility
{
    public class AccountBalanceRule : Rule
    {
        // Holds reference for next rule
        public AccountBalanceRule(Rule next) : base(next) { }

        // Sample concrete implementation
        public override bool RunRule(UserRequest request)
        {
            System.Console.WriteLine("Account Balance Rule is Run");
            if (request.Balance > 10000)
                return true;
            return false;
        }
    }
}