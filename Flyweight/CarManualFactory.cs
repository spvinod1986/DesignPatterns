using System.Collections.Generic;

namespace Flyweight
{
    public class CarManualFactory
    {
        private Dictionary<CarModel, CarManual> manuals = new Dictionary<CarModel, CarManual>();

        public CarManual GetCarManual(CarModel carModel)
        {
            if (!manuals.ContainsKey(carModel))
            {
                // logic to get car manual from cache if available or any other logic to fetch from some service
                var carManual = new CarManual(carModel, new byte[1000]);
                manuals.Add(carModel, carManual);
                System.Console.WriteLine($"New CarManual object created for {carModel}");
                return manuals.GetValueOrDefault(carModel);
            }

            System.Console.WriteLine($"CarManual retrieved from Memory for {carModel}");
            return manuals.GetValueOrDefault(carModel);
        }
    }
}