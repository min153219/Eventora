using Microsoft.AspNetCore.Identity;

namespace Eventora.Components.Domain
{
    public class User : IdentityUser
    {
        public string? FullName { get; set; }
        public string? PhoneNo { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}