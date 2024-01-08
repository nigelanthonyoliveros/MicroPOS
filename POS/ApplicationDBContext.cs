using Microsoft.EntityFrameworkCore;
using POS.Domains.Categories;
using POS.Domains.Items;
using POS.Domains.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options ):base(options)
        {
            Users = Set<User>();
            UserRoles = Set<UserRole>();
            Categories = Set<Category>();
            Products = Set<Product>();
            Rights = Set<Right>();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products  { get; set; }

        public DbSet<Right> Rights { get; set; }




    }
}
