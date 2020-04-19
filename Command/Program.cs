using System;
using System.Collections.Generic;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoiceService = new InvoiceService();
            var inventoryService = new InventoryService();

            var products = new List<Product>
            {
                new Product { Name = "Soap", Price = 10.00m },
                new Product { Name = "Juice", Price = 5.99m },
                new Product { Name = "PaperTowel", Price = 2.99m },
            };
            var command = new CompositeCommand();
            command.Add(new AddProductCommand(products[0], invoiceService, inventoryService));
            command.Add(new AddProductCommand(products[1], invoiceService, inventoryService));
            command.Add(new AddProductCommand(products[2], invoiceService, inventoryService));
            command.Add(new RemoveProductCommand(products[2], invoiceService, inventoryService));

            var cart = new Cart(command);
            cart.OneClickBuy();

            System.Console.WriteLine($"You purchased {invoiceService.TotalCountofProducts} item/s and your total price is {invoiceService.TotalPrice}");
            System.Console.WriteLine($"The {inventoryService.TotalCountofProducts} item/s purchased will be delivered on {inventoryService.DeliveryDate}");
        }
    }
}
