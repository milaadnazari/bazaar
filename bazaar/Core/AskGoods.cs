using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace bazaar.Core
{
    public class AskGoods : IdAndTime
    {
        public required Goods Goods { get; set; } = null!;
        public required Ask Ask { get; set; } = null!;
        [Column(TypeName = "decimal(18, 0)")]
        public required decimal Price { get; set; }
    }
}
