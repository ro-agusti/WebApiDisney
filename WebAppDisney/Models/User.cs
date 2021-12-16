using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace WebAppDisney.Models
{
    [Table("User")]
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Is Required")]
        [Column("varchar")]
        [StringLength(50)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Is Required")]
        [Column("varchar")]
        [StringLength(50)]
        [PasswordPropertyText]
        public string Password { get; set; }

        [Required(ErrorMessage = "Is Required")]
        [Column("varchar")]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
