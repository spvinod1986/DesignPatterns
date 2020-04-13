using System;

namespace State
{
    public class VehicleLoanProcessor : ILoanProcessor
    {
        public decimal CalculatePremium(string username, int interval)
        {
            System.Console.WriteLine($"Calculating premium for Vehicle Loan for {username}");
            return 1000.00m;
        }

        public bool CheckLoanEligibility(string username)
        {
            System.Console.WriteLine($"Checking eligibility for Vehicle Loan for {username}");
            return true;
        }

        public void ProcessLoan(string username, decimal amount)
        {
            System.Console.WriteLine($"Checking eligibility for Vehicle Loan for {username}");
        }
    }
}