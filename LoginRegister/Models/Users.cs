using Microsoft.AspNetCore.Identity;

namespace LoginRegister.Models
{
    public class Users : IdentityUser
    {
        public String FullName { get; set; }
    }
}
