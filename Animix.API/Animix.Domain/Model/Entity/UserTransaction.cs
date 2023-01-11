using Animix.Domain.Model.Enum;
using Animix.Domain.Model.Validations;
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
        [ForeignKey("FkUser")]
        public virtual User User { get; private set; }

        public UserTransaction(ETransactionType type, decimal value, User user)
        {
            Validation(type: type, value: value, user: user);
        }

        public void Validation(ETransactionType type, decimal value, User user)
        {
            DomainValidationException.When(value < 0, "O valor da transação não pode ser menor que zero!");
            DomainValidationException.When(user == null, "O usuário dono da transação deve ser informado!");

            Type = type;
            Value = value;
            User = user;
        }
    }
}
