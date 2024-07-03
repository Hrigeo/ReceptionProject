using Microsoft.EntityFrameworkCore;
using ReceptionProject.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace ReceptionProject.Data.Models
{
    [Comment("Guest of the hotel")]
    public class Guest
    {
        [Key]
        [Comment("Guest Identification")]
        public int Id { get; set; }
        [Required]
        [Comment("First name of the guest")]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [Comment("Last name of the Guest")]
        public string LastName { get; set; } = string.Empty;
        [Required]
        [Comment("Shows if the guest is an Adult(Over 18)")]
        public bool isAdult { get; set; }
        [Comment("The e-mail of the guest")]
        public string Email { get; set; }
        [Comment("Phone number of the guest")]
        public string Phone { get; set; }
        [Required]
        [Comment("The Address of the guest")]
        public string Address { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }


    }
}
//- `id`: unique identifier for the guest.
//- `firstname`: guest's first name.
//- `lastname`: guest's last name.
//- `isadult`: boolean indicating if the guest is an adult.
//- `email`: guest's email address for contact purposes.
//- `phonenumber`: guest's phone number.
//- `address`: guest's address.
//- `dateofbirth`: guest's date of birth (to verify age if needed).