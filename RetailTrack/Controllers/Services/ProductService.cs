using RetailTrack.Data;
using RetailTrack.Models.Products;

namespace RetailTrack.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;
        private readonly DesignService _designService;

        public ProductService(ApplicationDbContext context, DesignService designService)
        {
            _context = context;
            _designService = designService;
        }

        // Obtener todos los productos
        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        // Obtener un producto por ID
        public Product? GetProductById(Guid id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id) ?? throw new Exception("Producto no encontrado");
        }

        public async Task AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }


        // Actualizar un producto existente
        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        // Eliminar un producto
        public void DeleteProduct(Guid id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
