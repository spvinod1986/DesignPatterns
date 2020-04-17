using System;

namespace State
{
    // This class has dependency with interface which will be implemented by concrete classes
    public class LoanProcessingTool
    {
        private ILoanProcessor _processor;

        public ILoanProcessor GetCurrentProcessor()
        {
            return _processor;
        }

        public void SetCurrentProcessor(ILoanProcessor processor)
        {
            _processor = processor;
        }
        public decimal CalculatePremium(string username, int interval)
        {
            if (_processor == null)
                throw new Exception("Choose appropriate LoanType to calculate Premium");

            return _processor.CalculatePremium(username, interval);
        }

        public bool CheckLoanEligibility(string username)
        {
            if (_processor == null)
                throw new Exception("Choose appropriate LoanType to check loan eligibility");

            return _processor.CheckLoanEligibility(username);
        }

        public void ProcessLoan(string username, decimal amount)
        {
            if (_processor == null)
                throw new Exception("Choose appropriate LoanType to process loan");

            _processor.ProcessLoan(username, amount);
        }
    }
}
