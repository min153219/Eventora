using Eventora.Components.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventora.Data.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hasher = new PasswordHasher<User>();

            builder.HasData(
                new User
                {
                    Id = "1",
                    UserName = "admin@eventora.com",
                    NormalizedUserName = "ADMIN@EVENTORA.COM",
                    Email = "admin@eventora.com",
                    NormalizedEmail = "ADMIN@EVENTORA.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null!, "Admin@123"),
                    FullName = "System Administrator",
                    PhoneNo = "+65 1234 5678",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    SecurityStamp = Guid.NewGuid().ToString()
                }
            );
        }
    }
}