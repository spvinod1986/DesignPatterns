using System;

namespace ChainOfResponsibility
{
    public class AccountActiveRule : Rule
    {
        // Holds reference for next rule
        public AccountActiveRule(Rule next) : base(next) { }

        // Sample concrete implementation
        public override bool RunRule(UserRequest request)
        {
            System.Console.WriteLine("Account Active Rule is Run");
            if (DateTime.Now.Year - request.AccountActivatedAt.Year > 3)
                return true;
            return false;
        }
    }
}