using System;

namespace ChainOfResponsibility
{
    public class RuleEngine
    {
        // Holds reference to first rule to be executed
        private Rule rule;
        public RuleEngine(Rule rule)
        {
            this.rule = rule;
        }

        // Entry point for execution of rules
        public void ExecuteRule(UserRequest request)
        {
            // Does request validation
            if (request == null)
                throw new Exception("Request cannot be empty");

            // Executes first rule in the chain which will 
            // then recursively call other rules
            var result = rule.ExecuteRule(request);

            // Returns rule execution result in client friendly format
            if (result)
                System.Console.WriteLine($"{request.UserName} is eligible for loan");
            else
                System.Console.WriteLine($"{request.UserName} is not eligible for loan");
        }

    }
}