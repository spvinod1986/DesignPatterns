namespace Flyweight
{
    public class CarManual
    {
        public CarModel Model { get; private set; }

        // High memory consuming object
        public byte[] CarManualPDF { get; private set; }

        public CarManual(CarModel model, byte[] manualPDF)
        {
            Model = model;
            CarManualPDF = manualPDF;
        }
    }
}