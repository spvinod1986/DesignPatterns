namespace Template
{
    public class UHCPharmacyInsuranceValidator : PharmacyInsuranceValidator
    {
        public UHCPharmacyInsuranceValidator(PatientProfile patient) : base(patient)
        {
        }

        protected override decimal GetCoveragePrice(Drug drug)
        {
            return drug.Price / 5;
        }

        protected override bool IsDrugCovered(Drug drug)
        {
            return (drug.DrugCode.StartsWith("UHC"));
        }
    }
}