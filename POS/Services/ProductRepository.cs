using Microsoft.EntityFrameworkCore;
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

        public bool CheckDuplicate(Product product)
        {
            return  context.Products
                   .Any( pro => pro.ProductName.ToLower() == product.ProductName.Trim().ToLower() );
        }

        public async Task Delete(Product product)
        {
            if (CheckDuplicate(product))
            {
                context.Entry(product).State =  EntityState.Deleted;
                context.Products.Remove(product);
                await context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Product doesn't exists!");
            }
        }

        /// <summary>
        /// Returns all the available products ONLY when you provide the parameter available = true otherwise returns the all the products regardless of it's availability
        /// default is true
        /// </summary>
        /// <param name="available"></param>
        /// <returns>Task</returns>
        public async Task<IEnumerable<Product>> GetAllAsync
            (bool available = true)
        {
           if(available)
            {
                return await context.Products
               .Where(pro => pro.Available == true)
               .ToListAsync();
            }
           else
            {
                return await context.Products.ToListAsync();
            }
           
        }

        public Task<Product> GetById(Guid id)
        {
            return (Task<Product>)context.Products.Where(x => x.ProductID == id);
        }

        public async Task Update(Product product)
        {
            dynamic existingProduct = GetById(product.ProductID);
            if(existingProduct != null)
            {
               context.Entry(product).State = EntityState.Modified;
                await context.SaveChangesAsync();

            }
            else {

                throw new InvalidOperationException("Product does not exists!");
            }
        }
    }
}
