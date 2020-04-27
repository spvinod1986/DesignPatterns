using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class UsedCarService
    {
        private readonly List<UsedCar> _usedCars;
        private readonly CarManualFactory _carManualFactory;

        public UsedCarService()
        {
            _usedCars = new List<UsedCar>();
            _carManualFactory = new CarManualFactory();
        }

        public List<UsedCar> GetAvailableCarsForSale()
        {
            _usedCars.Add(new UsedCar { VINNumber = "VIN1", TotalMileage = 15000m, Manual = _carManualFactory.GetCarManual(CarModel.HondaCivic) });
            _usedCars.Add(new UsedCar { VINNumber = "VIN2", TotalMileage = 102000m, Manual = _carManualFactory.GetCarManual(CarModel.HondaCRV) });
            _usedCars.Add(new UsedCar { VINNumber = "VIN3", TotalMileage = 157000m, Manual = _carManualFactory.GetCarManual(CarModel.HondaCivic) });
            return _usedCars;
        }
    }
}