using System;

namespace State
{
    public class HomeLoanProcessor : ILoanProcessor
    {
        public decimal CalculatePremium(string username, int interval)
        {
            System.Console.WriteLine($"Calculating premium for Home Loan for {username}");
            return 1;
        }

        public bool CheckLoanEligibility(string username)
        {
            System.Console.WriteLine($"Checking eligibility for Home Loan for {username}");
            return true;
        }

        public void ProcessLoan(string username, decimal amount)
        {
            System.Console.WriteLine($"Processing Home Loan for {username}");
        }
    }
}