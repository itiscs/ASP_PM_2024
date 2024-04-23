using Microsoft.AspNetCore.Identity;

namespace IdentityApp.Models
{
    public class AppUser:IdentityUser
    {
        public int Age { get; set; }

    }
}
