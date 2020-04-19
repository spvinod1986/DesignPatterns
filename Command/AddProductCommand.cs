using System.Collections.Generic;
using System.Linq;

namespace Command
{
    public class AddProductCommand : IUndoableCommand
    {
        private List<Product> _previousProductsInInvoice;
        private List<Product> _previousProductsInInventory;
        private readonly CommandHistory _commandHistory;
        private readonly Product _product;
        private readonly InvoiceService _invoiceService;
        private readonly InventoryService _inventoryService;
        public AddProductCommand(Product product, InvoiceService invoiceService, InventoryService inventoryService, CommandHistory commandHistory)
        {
            _product = product;
            _invoiceService = invoiceService;
            _inventoryService = inventoryService;
            _commandHistory = commandHistory;
        }
        public void Execute()
        {
            _previousProductsInInvoice = _invoiceService.Products.ToList();
            _previousProductsInInventory = _inventoryService.Products.ToList();

            _invoiceService.AddProductToInvoice(_product);
            _inventoryService.AddProductToDelivery(_product);

            _commandHistory.Push(this);
        }

        public void UnExecute()
        {
            _invoiceService.Products = _previousProductsInInvoice;
            _inventoryService.Products = _previousProductsInInventory;
        }
    }
}