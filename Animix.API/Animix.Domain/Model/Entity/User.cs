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
        public string Name { get; private set; }
        public string NickName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public decimal Balance { get; private set; }
        public virtual List<UserTransaction> UserTransactions { get; private set; }

        //CRIAR USUÁRIO DO ZERO
        public User(string name, string nickName, string email, string password)
        {
            Validation(name : name, nickName : nickName, email : email, password : password);
        }

        //EDITAR ALGUM PARÂMETRO
        public User(int idUser, string name, string nickName, string email, string password, decimal balance, List<UserTransaction> userTransactions)
        {
            Validation(name: name, nickName: nickName, email: email, password: password);
            DomainValidationException.When(idUser < 0, "O Id do usuário deve ser informado");
            DomainValidationException.When(balance < 0, "O saldo da conta deve ser informado");
            DomainValidationException.When(userTransactions == null, "A lista de transações deve ser informada");

            IdUser = idUser;
            Balance = balance;
            UserTransactions = userTransactions;
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
