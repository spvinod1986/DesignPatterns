namespace Usps
{
    // External Proprietary Service Class
    // Non Editable for consuming client
    public class UspsService
    {
        public void CreateAndShipPackage(string address)
        {
            System.Console.WriteLine("Shipment created in USPS and will be shipped soon");
        }

        public void TrackPackage(string packageNumber)
        {
            System.Console.WriteLine($"Package {packageNumber} tracked in USPS");
        }
    }
}