using bazaar.Core;
using Microsoft.EntityFrameworkCore;

namespace bazaar.Persistance
{
    public class BazaarContext : DbContext
    {
        public BazaarContext(DbContextOptions<BazaarContext> options)
            : base(options)
        {
        }
        public DbSet<Ask> Asks { get; set; }
        public DbSet<AskGoods> AskGoods { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<CustomerPhone> CustomerPhones { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionGoods> questionGoods { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<GoodsCategory> GoodsCategories { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<SellerAddress> SellerAddresses { get; set; }
        public DbSet<SellerPhone> SellerPhones { get; set; }
    }
}
