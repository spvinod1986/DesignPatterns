using System;

namespace State
{
    public class BusinessLoanProcessor : ILoanProcessor
    {
        public decimal CalculatePremium(string username, int interval)
        {
            System.Console.WriteLine($"Calculating premium for Business Loan for {username}");
            return 1000.00m;
        }

        public bool CheckLoanEligibility(string username)
        {
            System.Console.WriteLine($"Checking eligibility for Business Loan for {username}");
            return true;
        }

        public void ProcessLoan(string username, decimal amount)
        {
            System.Console.WriteLine($"Checking eligibility for Business Loan for {username}");
        }
    }
}