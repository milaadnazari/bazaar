namespace bazaar.Core
{
    public class CustomerPhone : IdAndTime
    {
        public required string Number { get; set; }
        public required Customer Customer { get; set; } = null!;
    }
}
