using System.ComponentModel.DataAnnotations;

namespace IdentityService.Model
{
    public class User
    {

        [Required]
        public int Id { get; set; }
        public string UserName { get; set; }

  
        public string Email { get; set; }


        public string Address { get; set; }

 
        public int Phone { get; set; }
    }
}
