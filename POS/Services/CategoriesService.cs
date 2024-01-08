using Microsoft.Extensions.Logging;
using POS.Contracts;
using POS.Domains.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ILogger<CategoriesService> logger;
        private readonly ApplicationDBContext context;

        public CategoriesService(ILogger<CategoriesService> logger,ApplicationDBContext context) {
            this.logger=logger;
            this.context=context;
        }
        public async Task Add(Category category )
        {
            if (!CheckDuplicate(category))
            {
                try
                {
                    await context.Categories.AddAsync(category);
                    await context.SaveChangesAsync();
                    logger.LogInformation($"Category {category.CategoryID} was added successfully!");
                }
                catch (Exception e)
                {

                    throw new Exception($"Could not save: {e.Message}");
                }
            }
            
        }

        #region documentation
        /// <summary>
        /// Check if an entry already exists in the database
        /// </summary>
        /// <returns>true if there are existing records</returns>
#endregion 
        public bool CheckDuplicate(Category category)
        {
            return context.Categories
                                .Where(
                                      cat => cat.Name
                                                .ToLower()
                                                .Contains(category.Name.ToLower())
                                      )
                                .Count()>0;
        }

        public async Task Delete(Category category)
        {
            context.Categories.Remove(category);
           await context.SaveChangesAsync();
           

        }

        public async Task Update(Category category)
        {
          if(CheckDuplicate(category))
            {

                context.Update(category);
                await context.SaveChangesAsync();

            }
            else
            {
                throw new InvalidOperationException("There is no record to update.");
            }
        }
    }
}
