using System.Collections.Generic;
using SportsStore.Domain.Concrete;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract
{
    public class EFProductRepository : IProductRepository
    {
        private readonly EFDbContext _context = new EFDbContext();

        public IEnumerable<Product> Products => _context.Products;
    }
}