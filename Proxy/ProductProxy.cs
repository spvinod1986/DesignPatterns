namespace Proxy
{
    public class ProductProxy : Product
    {
        private readonly ProductContext _context;
        public ProductProxy(int Id, ProductContext context)
        {
            _context = context;
            base.Id = Id;
        }

        public override int Id
        {
            get
            {
                return base.Id;
            }
        }

        public override string Name
        {
            get
            {
                return base.Name;
            }
            set
            {
                base.Name = value;
                _context.MarkProductAsChanged(this);
            }
        }

        public override string Description
        {
            get
            {
                return base.Description;
            }
            set
            {
                base.Description = value;
                _context.MarkProductAsChanged(this);
            }
        }

        public override decimal Price
        {
            get
            {
                return base.Price;
            }
            set
            {
                base.Price = value;
                _context.MarkProductAsChanged(this);
            }
        }
    }
}