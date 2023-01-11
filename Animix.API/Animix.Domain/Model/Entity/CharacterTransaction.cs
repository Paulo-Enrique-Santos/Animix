using Animix.Domain.Model.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Animix.Domain.Model.Entity
{
    [Table("transacoesAnimacoes")]
    public class CharacterTransaction
    {
        private CharacterTransaction() { }
        [Key]
        public int IdCharacterTransaction { get; set; }
        public decimal Price { get; private set; }
        public User Buyer { get; private set; }
        public User Seller { get; private set; }
        [ForeignKey("FkCharacter")]
        public virtual Character Character { get; set; }

        public CharacterTransaction (decimal price, User buyer, User seller, Character character)
        {
            DomainValidationException.When(price < 0, "O preço deve ser informado!");
            DomainValidationException.When(buyer == null, "O Comprador deve ser informado!");
            DomainValidationException.When(character == null, "O Personagem deve ser informado!");

            Price = price;
            Buyer = buyer;
            Seller = seller;
            Character = character;
        }
    }
}
