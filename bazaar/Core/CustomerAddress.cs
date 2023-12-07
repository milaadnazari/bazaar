namespace bazaar.Core
{
    public class CustomerAddress : IdAndTime
    {
        public required string Text { get; set; }
        public required Customer Customer { get; set; } = null!;
    }
}
