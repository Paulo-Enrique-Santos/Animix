using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Animix.Domain.Model.Entity
{
    [Table("Usuario")]
    public class User
    {
        [Key]
        public int IdUser { get; private set; }
        public string Name { get; private set; }
        public string NickName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public decimal Balance { get; private set; }

        public virtual List<UserTransaction> UserTransactions { get; private set; }
    }
}
