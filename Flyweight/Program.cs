using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var usedCarService = new UsedCarService();
            foreach (var usedCar in usedCarService.GetAvailableCarsForSale())
            {
                System.Console.WriteLine($"Displaying available used car information for {usedCar.VINNumber}");
            }
        }
    }
}
