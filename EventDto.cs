namespace Raceday.API.DTOs
{
    public class EventDto
    {
        public int EventId { get; set; }
        public string EventName { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public string Location { get; set; } = string.Empty;
        public int MaxParticipants { get; set; }
        public string Status { get; set; } = string.Empty;
        public int OrganiserId { get; set; }
        public List<CategoryDto> Categories { get; set; } = new();
    }

    public class CreateEventDto
    {
        public string EventName { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public string Location { get; set; } = string.Empty;
        public int MaxParticipants { get; set; }
    }

    public class UpdateEventDto
    {
        public string EventName { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public string Location { get; set; } = string.Empty;
        public int MaxParticipants { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
