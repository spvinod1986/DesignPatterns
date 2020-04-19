namespace Command
{
    public class AddProductCommand : ICommand
    {
        private readonly Product _product;
        private readonly InvoiceService _invoiceService;

        private readonly InventoryService _inventoryService;
        public AddProductCommand(Product product, InvoiceService invoiceService, InventoryService inventoryService)
        {
            _product = product;
            _invoiceService = invoiceService;
            _inventoryService = inventoryService;
        }
        public void Execute()
        {
            _invoiceService.AddProductToInvoice(_product);
            _inventoryService.AddProductToDelivery(_product);
        }
    }
}