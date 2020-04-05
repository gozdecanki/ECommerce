using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce.Data.DTOs
{
   public class User_RegisterAction_Request
    {
        [Required, MaxLength(50), MinLength(2)]
        public string Name { get; set; }

        [Required, MaxLength(50), MinLength(2)]
        public string Surname { get; set; }

        [Required, MaxLength(350), MinLength(6)]
        public string Email { get; set; }

        [Required, MinLength(8), MaxLength(64)]
        public string Password { get; set; }
    }
}
