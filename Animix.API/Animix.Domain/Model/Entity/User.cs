using Animix.Domain.Model.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Animix.Domain.Model.Entity
{
    [Table("usuario")]
    public class User
    {
        private User() { }
        [Key]
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
        public virtual List<UserTransaction> UserTransactions { get; set; }

        public User(string name, string nickName, string email, string password)
        {
            Validation(name : name, nickName : nickName, email : email, password : password);
        }

        private void Validation(string name, string nickName, string email, string password)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "O nome do usuário deve ser informado!");
            DomainValidationException.When(string.IsNullOrEmpty(nickName), "O apelido do usuário deve ser informado!");
            DomainValidationException.When(string.IsNullOrEmpty(email), "O email do usuário deve ser informado!");
            DomainValidationException.When(string.IsNullOrEmpty(password), "A senha do usuário deve ser informada!");

            Name = name;
            NickName = nickName;
            Email = email;
            Password = password;
            Balance = 0;
            UserTransactions = new List<UserTransaction>();
        }
    }
}
