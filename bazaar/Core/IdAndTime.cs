namespace bazaar.Core
{
    public abstract class IdAndTime
    {
        public long Id { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}
