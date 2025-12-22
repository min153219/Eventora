namespace Eventora.Components.Domain
{
    public class Ticket : BaseDomainModel
    {
        public decimal Price { get; set; }
        public string? Type { get; set; }

        // Foreign Key
        public int EventId { get; set; }
    }
}
