using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Animix.Domain.Model.Entity
{
    [Table("transacoesAnimacoes")]
    public class CharacterTransaction
    {
        [Key]
        public int IdCharacterTransaction { get; private set; }
        public decimal Price { get; private set; }
        public int FkBuyer { get; private set; }
        public int FkSeller { get; private set; }
        public int FkCharacter { get; private set; }
        [ForeignKey("FkCharacter")]
        public virtual Character Character { get; set; }
    }
}
