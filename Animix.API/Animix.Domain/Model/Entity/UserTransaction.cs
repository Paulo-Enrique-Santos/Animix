using Animix.Domain.Model.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Animix.Domain.Model.Entity
{
    [Table("transacoesUsuario")]
    public class UserTransaction
    {
        [Key]
        public int IdUserTransaction { get; private set; }
        public ETransactionType Type { get; private set; }
        public decimal Value { get; private set; }
        public int FkUser { get; private set; }
        [ForeignKey("FkUser")]
        public virtual User User { get; private set; }
    }
}
