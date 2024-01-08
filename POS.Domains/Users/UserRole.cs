using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domains.Users
{

    [Table("tblUserRoles",Schema ="dbo")]
    public class UserRole
    {
        [Key]
        public Guid RoleID { get; set; }
        [StringLength(maximumLength:30 ,MinimumLength = 3)]
        [Required]
        public string RoleName { get; set; } = string.Empty;
        public List<Right> Rights { get; set; } = new List<Right>();
        public List<User> Users { get; set; } = new List<User>();
    }
}
