using Microsoft.AspNetCore.Identity;

namespace Eventora.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class EventoraContextUser : IdentityUser
    {
        public string? FullName { get; set; }
        
    }
}