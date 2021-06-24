using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneContacts.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        public String PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter an address.")]
        public String Address { get; set; }

        public string Note { get; set; }


    }
}
