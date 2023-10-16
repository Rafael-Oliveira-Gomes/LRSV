using Microsoft.AspNetCore.Identity;

namespace WebTest.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
    }
}
