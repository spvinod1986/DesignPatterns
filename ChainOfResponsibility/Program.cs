using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define order of execution of rules
            var creditScoreRule = new CreditScoreRule(null);
            var accountActiveRule = new AccountActiveRule(creditScoreRule);
            var accountBalanceRule = new AccountBalanceRule(accountActiveRule);

            // Instantiate engine class with the rule object expected to execute first
            var ruleEngine = new RuleEngine(accountBalanceRule);

            // Execute Rule with request object
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
