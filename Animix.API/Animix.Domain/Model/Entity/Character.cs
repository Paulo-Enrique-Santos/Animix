using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Animix.Domain.Model.Entity
{
    [Table("personagem")]
    public class Character
    {
        [Key]
        public int IdCharacter { get; private set; }
        public string Name { get; private set; }
        public bool[] Image { get; private set; }
        public int FkAnimation { get; private set; }
        [ForeignKey("FkAnimation")]
        public virtual Animation Animation { get; private set; }
        public int FkOwner { get; private set; }
        [ForeignKey("FkOwner")]
        public virtual User User { get; private set; }
        public virtual Marketplace Marketplace { get; private set; }
        public virtual List<CharacterTransaction> CharacterTransactions { get; private set; }
    }
}
