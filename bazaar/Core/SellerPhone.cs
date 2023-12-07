using System.ComponentModel.DataAnnotations.Schema;

namespace bazaar.Core
{
    public class SellerPhone : IdAndTime
    {
        public long SellerID { get; set; }
        public required string Phone { get; set; }
        public required Seller Seller { get; set; } = null!;
    }


}
