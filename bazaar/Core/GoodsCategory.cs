namespace bazaar.Core
{
    public class GoodsCategory : IdAndTime
    {
        public required string Title { get; set; }
        public List<Goods> Goods { get; } = new();
    }


}
