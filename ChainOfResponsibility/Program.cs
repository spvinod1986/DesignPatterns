using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var creditScoreRule = new CreditScoreRule(null);
            var accountActiveRule = new AccountActiveRule(creditScoreRule);
            var accountBalanceRule = new AccountBalanceRule(accountActiveRule);

            var ruleEngine = new RuleEngine(accountBalanceRule);
            ruleEngine.ExecuteRule(new UserRequest
            {
                UserName = "John",
                Balance = 8000,
                CreditScore = 450,
                AccountActivatedAt = DateTime.Now.AddYears(-4)
            });
        }
    }
}
