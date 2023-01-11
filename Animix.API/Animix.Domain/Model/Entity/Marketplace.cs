using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Animix.Domain.Model.Entity
{
    [Table("anuncios")]
    public class Marketplace
    {
        [Key]
        public int IdMarketplace { get; private set; }
        public decimal Price { get; private set; }
        public int FkCharacter { get; private set; }
        [ForeignKey("FkCharacter")]
        public virtual Character Character { get; private set; }
    }
}
