using POS.Contracts;
using POS.Domains.Categories;
using POS.Domains.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Services
{
    public class POSService : IPOSService
    {
        public readonly ICategoryRepository categoryRepository;
        public readonly IProductRepository productRepository;
 

        public POSService(
                ICategoryRepository categoryRepository , 
                IProductRepository productRepository 
           )
        {
            this.categoryRepository=categoryRepository;
            this.productRepository=productRepository;

        }


        #region Categories
        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            dynamic categories = await categoryRepository.GetAllCategory();
            return categories;
        }

        public async Task AddCategoryAsync(Category category)
        {
            await categoryRepository.Add(category);

        }

        public async Task DeleteCategoryAsync(Category category)
        {
            await categoryRepository.Delete(category);
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            await categoryRepository.Update(category);

        }

        public async Task<Category?> GetCategoryAsync(Guid id)
        {
           return await categoryRepository.GetById(id);
        }

        #endregion


        #region Products

        public async Task AddProduct(Product product)
        {

            if (!ProductExists(product))
            {
                await productRepository.Add(product);
           
            }
            else
            {

                throw new Exception("Product already exists!");
            }

        }
        public bool ProductExists(Product product)
        {
            //For now let's just do the checking of product name
            return productRepository.CheckDuplicate(product);


        }

        public async Task<IEnumerable<Product>> GetAllAvailableProducts(bool available = true) => await productRepository.GetAllAsync(available);
        public async Task<Product> GetProduct(Guid id) => await productRepository.GetById(id);

        public async Task UpdateProduct(Product product) =>await productRepository.Update(product);
     
        public async Task DeleteProduct(Product product)=> await 
          productRepository.Delete(product);



        #endregion

        public void Dispose()
        {
            this.Dispose();
        }

    }
}
