using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartApplication.Model
{
    public class RegisterInfo
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Username")]
        [StringLength(50)]
        public string Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Password")]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Phone")]
        [Phone]
        public string Phone { get; set; }
    }
}
