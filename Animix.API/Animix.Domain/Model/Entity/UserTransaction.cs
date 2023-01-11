using Animix.Domain.Model.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Animix.Domain.Model.Entity
{
    public class UserTransaction
    {
        public int IdUserTransaction { get; private set; }
        public ETransactionType Type { get; private set; }
        public decimal Value { get; private set; }
        public int FkUser { get; private set; }
        [ForeignKey("FkUser")]
        public virtual User User { get; private set; }
    }
}
