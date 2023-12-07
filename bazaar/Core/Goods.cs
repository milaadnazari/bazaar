namespace bazaar.Core
{
    public class Goods : IdAndTime
    {
        public required string Title { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public List<GoodsCategory> GoodsCategories { get; } = new();
        public ICollection<QuestionGoods> QuestionGoods { get; set; } = new List<QuestionGoods>();
        public ICollection<AskGoods> AskGoods { get; set; } = new List<AskGoods>();
    }
}
