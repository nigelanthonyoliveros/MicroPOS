using POS.Domains.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Contracts
{
    public interface IProductRepository
    {
        Task Add(Product product);
        Task Update(Product product);
        Task Delete(Product product);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetById(Guid id);
    }
}
