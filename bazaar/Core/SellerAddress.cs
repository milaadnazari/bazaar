using System.ComponentModel.DataAnnotations.Schema;

namespace bazaar.Core
{
    public class SellerAddress : IdAndTime
    { 
        public long SellerID { get; set; }
        public required string Address { get; set; }
        public required Seller Seller { get; set; } = null!;
    }


}
