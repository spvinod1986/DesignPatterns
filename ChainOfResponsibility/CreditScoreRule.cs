namespace ChainOfResponsibility
{
    public class CreditScoreRule : Rule
    {
        // Holds reference for next rule
        public CreditScoreRule(Rule next) : base(next) { }

        // Sample concrete implementation
        public override bool RunRule(UserRequest request)
        {
            System.Console.WriteLine("Credit Score Rule is Run");
            if (request.CreditScore > 400)
                return true;
            return false;
        }
    }
}