namespace bazaar.Core
{
    public class Question : IdAndTime
    {
        public long CustomerId { get; set; }
        public long UserId { get; set; }
        public required Customer Customer { get; set; }
        public required User User { get; set; }
        public ICollection<QuestionGoods> QuestionGoods { get; set; } = new List<QuestionGoods>();
    }
}
