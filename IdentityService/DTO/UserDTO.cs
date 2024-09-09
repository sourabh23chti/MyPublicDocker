using System.ComponentModel.DataAnnotations;

namespace IdentityService.DTO
{
    public class UserDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int Phone { get; set; }
    }
}
