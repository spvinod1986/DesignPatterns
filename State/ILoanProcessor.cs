using System;

namespace State
{
    public interface ILoanProcessor
    {
        bool CheckLoanEligibility(string username);

        void ProcessLoan(string username, decimal amount);

        decimal CalculatePremium(string username, int interval);
    }
}
