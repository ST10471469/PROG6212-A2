namespace RaceDay.API.Models
{
    public class Organiser
    {
        public int OrganiserId { get; set; }
        public string OrganiserName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int RoleId { get; internal set; }
        public string RoleName { get; internal set; }
    }
}