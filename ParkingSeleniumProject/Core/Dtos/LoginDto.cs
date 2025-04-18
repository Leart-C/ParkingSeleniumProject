using System.ComponentModel.DataAnnotations;

namespace ParkingSeleniumProject.Core.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Password is required")]


        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
