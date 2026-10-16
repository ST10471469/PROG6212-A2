namespace Raceday.API.DTOs
{
    public class ResultDto
    {
        public int ResultId { get; set; }
        public int EnrolmentId { get; set; }
        public string ParticipantName { get; set; } = string.Empty;
        public string EventName { get; set; } = string.Empty;
        public TimeSpan FinishTime { get; set; }
        public int OverallRank { get; set; }
        public int CategoryRank { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Email { get; internal set; }
        public string Role { get; internal set; }
        public int ParticipantId { get; internal set; }
        public string FirstName { get; internal set; }
    }

    public class CreateResultDto
    {
        public int EnrolmentId { get; set; }
        public TimeSpan FinishTime { get; set; }
        public int OverallRank { get; set; }
        public int CategoryRank { get; set; }
        public string Status { get; set; } = "Official";
    }
}
