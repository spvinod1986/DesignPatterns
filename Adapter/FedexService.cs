namespace Fedex
{
    // External Proprietary Service Class
    // Non Editable for consuming client
    public class FedexService
    {
        public void CreateShipment(string address, string shipmentName)
        {
            System.Console.WriteLine($"Your shipment for {shipmentName} created in Fedex and will be delivered tomorrow");
        }

        public void TrackShipment(string shipmentId)
        {
            System.Console.WriteLine($"Shipment {shipmentId} tracked in Fedex");
        }
    }
}