namespace bazaar.Core
{
    public class Customer : IdAndTime
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public ICollection<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();
        public ICollection<CustomerPhone> CustomerPhones { get; set; } = new List<CustomerPhone>();
        public ICollection<Question> Questions { get; set; } = new List<Question>();

    }
}
