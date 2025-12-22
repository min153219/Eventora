using Eventora.Components.Domain;
using Eventora.Data.Configurations.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Eventora.Data
{
    public class EventoraContext : DbContext
    {
        public EventoraContext(DbContextOptions<EventoraContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = default!;
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
        }
    }
}