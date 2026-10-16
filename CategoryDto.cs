namespace Raceday.API.DTOs
{
    public class CategoryDto
    {
        public string CategoryName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string AgeGroup { get; set; } = string.Empty;
        public string GenderSpecific { get; set; } = string.Empty;
    }
}
