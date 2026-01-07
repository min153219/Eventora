using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Eventora.Components.Domain;
using Eventora.Data.Configurations.Entities;
using Microsoft.EntityFrameworkCore;


namespace Eventora.Data
{
    public class EventoraContext(DbContextOptions<EventoraContext> options): IdentityDbContext<EventoraContextUser>(options)

    {
        public DbSet<Event> Events { get; set; } = default!;
        public DbSet<EventType> EventTypes { get; set; } = default!;
        public DbSet<Ticket> Tickets { get; set; } = default!;
        public DbSet<Registration> Registrations { get; set; } = default!;
        public DbSet<Payment> Payments { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Apply seed data configurations
            builder.ApplyConfiguration(new EventTypeSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
        }
    }
}