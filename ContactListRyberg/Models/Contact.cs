using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactListRyberg.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        [Required(ErrorMessage="Please enter your first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Please enter your last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Please enter your email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [Range(1111111111, 9999999999, ErrorMessage = "Check that your phone number is valid")]
        public long? PhoneNumber { get; set; }


    }
}
