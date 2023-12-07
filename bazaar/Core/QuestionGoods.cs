using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace bazaar.Core
{
    public class QuestionGoods : IdAndTime
    {
        [Column(TypeName = "decimal(18, 0)")]
        public required decimal Price { get; set; }
        public required Goods Goods { get; set; } = null!;
        public required Question Question { get; set; } = null!;
    }
}
