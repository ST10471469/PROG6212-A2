namespace Raceday.API.DTOs
{
    public class EnrolmentDto
    {
        public int EnrolmentId { get; set; }
        public int EventId { get; set; }
        public string EventName { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public int ParticipantId { get; set; }
        public string ParticipantName { get; set; } = string.Empty;
        public DateTime RegistrationDate { get; set; }
        public string PaymentStatus { get; set; } = string.Empty;
        public decimal AmountPaid { get; set; }
        public int? BibNumber { get; set; }
    }

    public class CreateEnrolmentDto
    {
        public int CategoryId { get; set; }
    }
}
