namespace bazaar.Core
{
    public class Seller : IdAndTime
    {
        public required string Title { get; set; }
        public ICollection<SellerAddress> SellerAddresses { get; } = new List<SellerAddress>();
        public ICollection<SellerPhone> SellerPhones { get; } = new List<SellerPhone>();
        public ICollection<Ask> Asks { get; } = new List<Ask>();
    }


}
