using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using POS.Contracts;
using POS.Domains.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly ILogger<ProductRepository> logger;
        private readonly ApplicationDBContext context;

        public ProductRepository(ILogger<ProductRepository> logger, ApplicationDBContext context)
        {
            this.logger=logger;
            this.context=context;
        }
        public async Task Add(Product product)
        {
            await context.Products.AddAsync(product);
             await  context.SaveChangesAsync();
        }

        public Task Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetById(Guid id)
        {
            return (Task<Product>)context.Products.Where(x => x.ProductID == id);
        }

        public Task Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
