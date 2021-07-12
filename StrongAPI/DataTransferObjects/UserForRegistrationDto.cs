using System.ComponentModel.DataAnnotations;

namespace StrongAPI.DataTransferObjects
{
    public class UserForRegistrationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Instrument { get; set; }
        public string Genre { get; set; }
        public string Band { get; set; }
        public string ImageURL { get; set; }
    }
}
