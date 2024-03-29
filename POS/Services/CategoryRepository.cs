﻿using Microsoft.EntityFrameworkCore;
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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ILogger<CategoryRepository> logger;
        private readonly ApplicationDBContext context;

        public CategoryRepository(ILogger<CategoryRepository> logger,ApplicationDBContext context) {
            this.logger=logger;
            this.context=context;
        }
        /// <summary>
        /// Adds a new category to the database.
        /// </summary>
        /// <param name="category">The category to be added.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
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
            .Where(  cat => cat.Name.ToLower().Contains(category.Name.ToLower())
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

        public async Task<IEnumerable<Category>> GetAllCategory()
        {

            return await context.Categories.ToListAsync();
        }

        public async Task<Category?> GetById(Guid id)
        {
           return await context.Categories
                    .FirstOrDefaultAsync(cat => cat.CategoryID == id);
            
        }   
    }
}
