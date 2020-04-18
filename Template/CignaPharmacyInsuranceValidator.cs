namespace Template
{
    public class CignaPharmacyInsuranceValidator : PharmacyInsuranceValidator
    {
        public CignaPharmacyInsuranceValidator(PatientProfile patient) : base(patient)
        {
        }

        protected override decimal GetCoveragePrice(Drug drug)
        {
            return drug.Price / 2;
        }

        protected override bool IsDrugCovered(Drug drug)
        {
            return (drug.DrugCode.StartsWith("CI"));
        }

        protected override void CreatePatientSummaryReport()
        {
            System.Console.WriteLine($"Patient Summary Report created in CIGNA format");
        }
    }
}