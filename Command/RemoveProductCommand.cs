namespace Command
{
    public class RemoveProductCommand : ICommand
    {
        private readonly Product _product;
        private readonly InvoiceService _invoiceService;

        private readonly InventoryService _inventoryService;
        public RemoveProductCommand(Product product, InvoiceService invoiceService, InventoryService inventoryService)
        {
            _product = product;
            _invoiceService = invoiceService;
            _inventoryService = inventoryService;
        }
        public void Execute()
        {
            _invoiceService.RemoveProductFromInvoice(_product);
            _inventoryService.RemoveProductFromDelivery(_product);
        }
    }
}