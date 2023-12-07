namespace bazaar.Core
{
    public class Ask : IdAndTime
    {
        public required Seller Seller { get; set; }
        public required User User { get; set; }
        public ICollection<AskGoods> AskGoods { get; set; }=new List<AskGoods>();
    }
}
