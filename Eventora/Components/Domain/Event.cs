namespace Eventora.Components.Domain
{
    public class Event : BaseDomainModel
    {
        public string? Title { get; set; }
        public DateTime DateTime { get; set; }
        public string? Location { get; set; }
        public int TotalCapacity { get; set; }
        // Foreign Keys
        public int UserId { get; set; }
        public int EventTypeId { get; set; }

    }
}
