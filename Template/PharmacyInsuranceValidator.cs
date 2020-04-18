namespace Template
{
    public abstract class PharmacyInsuranceValidator
    {
        private readonly PatientProfile _patient;
        public PharmacyInsuranceValidator(PatientProfile patient)
        {
            _patient = patient;
        }
        // Template method
        public void ValidateDrug(Drug drug)
        {
            // check if drug is over counter medicine
            if (IsDrugAvailableOverCounter(drug))
            {
                System.Console.WriteLine($"Drug {drug.DrugCode} is available over counter and not covered in insurance");
                return;
            }

            // check if drug is covered by insurance
            if (IsDrugCovered(drug))
            {
                // if covered then get the coverage price to calculate patient price
                var coveragePrice = GetCoveragePrice(drug);
                System.Console.WriteLine($"Drug {drug.DrugCode} is covered and the cost to collect from patient is { drug.Price - coveragePrice }");
            }
            else
            {
                System.Console.WriteLine($"Drug {drug.DrugCode} is not covered and the cost to collect from patient is { drug.Price }");
            }

            // Create patient summary report
            CreatePatientSummaryReport();
            SendReportToPatient();
        }

        private bool IsDrugAvailableOverCounter(Drug drug)
        {
            return drug.DrugCode.StartsWith("OC");
        }

        protected abstract bool IsDrugCovered(Drug drug);
        protected abstract decimal GetCoveragePrice(Drug drug);

        // Hook Method
        protected virtual void CreatePatientSummaryReport()
        {
            System.Console.WriteLine($"Patient Summary Report created in default format");
        }

        private void SendReportToPatient()
        {
            System.Console.WriteLine("Patient Report shared by email");
        }
    }
}