namespace Eventora.Components.Domain
{
    public class Registration : BaseDomainModel
    {
        public DateTime RegistrationDate { get; set; }

        // Foreign Keys
        public int UserId { get; set; }
        public int EventId { get; set; }
        public int TicketId { get; set; }
    }
}
