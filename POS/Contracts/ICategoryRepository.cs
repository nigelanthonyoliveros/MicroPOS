using POS.Domains.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Contracts
{
    public interface ICategoryRepository
    {
        Task Add(Category category);
        Task Update(Category category);
        Task Delete(Category category);

        bool CheckDuplicate(Category category);
    }
}
