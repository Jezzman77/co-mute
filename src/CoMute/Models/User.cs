using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoMute.Web.Models
{
    public class User
    {

        public int UserId { get; set; }

        [Required(ErrorMessage ="Enter name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Surname.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Enter Email.")]
        
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Enter PhoneNumber.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Enter Password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
