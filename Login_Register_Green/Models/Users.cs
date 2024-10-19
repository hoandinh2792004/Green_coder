using Microsoft.AspNetCore.Identity;

namespace Login_Register_Green.Models
{
    public class Users : IdentityUser
    {
        public String FullName { get; set; }
    }
}
