using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Domains.Items;

namespace POS.Domains.Categories
{
    [Table("tblCategory",Schema ="dbo")]
    public class Category
    {
        [Key]
        public Guid CategoryID { get; set; }

        [Required(ErrorMessage = "Category name is required")]
        [StringLength(50,ErrorMessage = "Maximum of 50 characters" )]
        [Column("Category_Name")]
        public string Name { get; set; } = string.Empty;
        [Column("Description")]
        [StringLength(100,MinimumLength =10)]
        public string Description { get; set; }

        public Category(string Name = "Unnamed Category", string Description = "")
        {
            this.Name = Name;
                this.Description = Description;
        }
        [Column("DateCreated")]
        public DateTime Created { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();


    }
}
