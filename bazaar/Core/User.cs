namespace bazaar.Core
{
    public class User : IdAndTime
    {
        public required string Name { get; set; }
        public required string Password { get; set; }
        public ICollection<Question> Questions { get; set; } = new List<Question>();
        public ICollection<Ask> Asks { get; set; } = new List<Ask>();
    }
}
