using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EFProductRepository : IProductRepository
    {
        public EFProductRepository(ApplicationDbContext ctx)
        {
            this.context = ctx;
        }
        private ApplicationDbContext context;

        public IEnumerable<Product> Products => context.Products;
    }
}
