using System.ComponentModel.DataAnnotations;

namespace POS.Domains.Users
{

    public class Right
    {
        [Key]
        public Guid RightID { get; set; }
        [Required]
        public string RightName { get; set; } = string.Empty;


    }
}