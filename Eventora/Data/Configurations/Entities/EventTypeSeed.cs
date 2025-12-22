using Eventora.Components.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventora.Data.Configurations.Entities
{
    public class EventTypeSeed : IEntityTypeConfiguration<EventType>
    {
        public void Configure(EntityTypeBuilder<EventType> builder)
        {
            builder.HasData(
                new EventType
                {
                    Id = 1,
                    TypeName = "Workshop",
                    Description = "Educational and skill-building sessions",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new EventType
                {
                    Id = 2,
                    TypeName = "Concert",
                    Description = "Live music performances",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new EventType
                {
                    Id = 3,
                    TypeName = "Community Event",
                    Description = "Local community gatherings",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
