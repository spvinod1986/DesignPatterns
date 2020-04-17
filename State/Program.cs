using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var loanProcessor = new LoanProcessingTool();

            loanProcessor.SetCurrentProcessor(new HomeLoanProcessor());
            loanProcessor.CheckLoanEligibility("TestUser");
            loanProcessor.CalculatePremium("TestUser", 1);
            loanProcessor.ProcessLoan("TestUser", 10);

            loanProcessor.SetCurrentProcessor(new BusinessLoanProcessor());
            loanProcessor.CheckLoanEligibility("TestUser");
            loanProcessor.CalculatePremium("TestUser", 1);
            loanProcessor.ProcessLoan("TestUser", 10000m);

            loanProcessor.SetCurrentProcessor(new VehicleLoanProcessor());
            loanProcessor.CheckLoanEligibility("TestUser");
            loanProcessor.CalculatePremium("TestUser", 1);
            loanProcessor.ProcessLoan("TestUser", 10000m);
        }
    }
}
