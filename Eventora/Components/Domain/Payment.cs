namespace Eventora.Components.Domain
{
    public class Payment : BaseDomainModel
    {
        public decimal Amount { get; set; }
        public string? PaymentMethod { get; set; }
        public string? Currency { get; set; }
        public DateTime PaymentDate { get; set; }

        // Foreign Key
        public int RegistrationId { get; set; }
    }
}
