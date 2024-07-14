using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Models.DTOs.Request.User
{
    public class RegisterUserWithAvatarDTO
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z\d]).{8,}$",
          ErrorMessage = "- Length: Password should be at least 8 characters\\n" +
          "- Use both uppercase and lowercase letters: Combine uppercase and lowercase letters.\\n" +
          "- No spaces, at least 1 special character, 1 letter, 1 number")]
        public string Password { get; set; }

      
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmedPassword { get; set; }
        //[Required(ErrorMessage = " is required")]
        public string Avatar { get; set; }
    }  
   }
