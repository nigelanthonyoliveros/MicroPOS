using Microsoft.EntityFrameworkCore;
using POS.Domains.Categories;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace POS.Domains.Items
{
    public class Product
    {
        [Key]

        public Guid ProductID { get; set; }
        public string? SKU {  get; set; }

        [MaxLength(100)]
        [Required(AllowEmptyStrings =false)]
        [Unicode(true)]
        public string ProductName { get; set; } = string.Empty;


        [StringLength(100, MinimumLength = 3)]
        [Required(AllowEmptyStrings = false)]
        public string ProductDescription { get; set; } = string.Empty;

        [Column("Price",TypeName ="decimal(8,2)")]
        [DataType(DataType.Currency)]
        [Required]
        public decimal ProductPrice { get; set; }




        [ForeignKey("Category")]
        public Guid CategoryID { get; set; }
        public Category? Category { get; set; }
    }
}