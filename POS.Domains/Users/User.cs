using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domains.Users
{
    [Table("tblUsers",Schema ="dbo")]
    public class User
    {
        [Key]
        public Guid UserID { get; set; }

        [Required(AllowEmptyStrings= false,ErrorMessage ="Username is required")]
        [StringLength(50,MinimumLength =3)]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [ForeignKey("Role")]
        public Guid RoleID { get; set; }
        public UserRole? Role { get; set; }

    }
}
