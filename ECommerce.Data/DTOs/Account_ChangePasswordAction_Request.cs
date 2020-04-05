using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce.Data.DTOs
{
   public class Account_ChangePasswordAction_Request
    {
        [Required,MinLength(8),MaxLength(64)]// bu satır yazılmadığında ddos saldırıları için açık yaratır
        public string Password { get; set; }

        [Required, MinLength(8), MaxLength(64)]
        public string NewPassword { get; set; }
    
    }
}
