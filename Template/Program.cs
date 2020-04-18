using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            var patient = new PatientProfile
            {
                Name = "TestPatient",
                Age = 30
            };
            // validate with CIGNA Insurance if the patient holds that insurance
            var cignaInsuranceValidator = new CignaPharmacyInsuranceValidator(patient);
            cignaInsuranceValidator.ValidateDrug(new Drug { DrugCode = "CI-123", Price = 100.00m });

            var uhcInsuranceValidator = new UHCPharmacyInsuranceValidator(patient);
            uhcInsuranceValidator.ValidateDrug(new Drug { DrugCode = "UHC-123", Price = 100.00m });
        }
    }
}
