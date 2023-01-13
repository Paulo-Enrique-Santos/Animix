using Animix.Domain.Model.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Animix.Domain.Model.Entity
{
    [Table("anuncios")]
    public class Marketplace
    {
        private Marketplace() { }
        [Key]
        public int IdMarketplace { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("FkCharacter")]
        public virtual Character Character { get; private set; }

        public Marketplace(decimal price, Character character)
        {
            Validation(price : price, character : character);
        }

        public void Validation(decimal price, Character character)
        {
            DomainValidationException.When(price <= 0, "O preço do personagem não pode ser menor ou igual a zero");
            DomainValidationException.When(character == null, "O personagem deve ser informado!");

            Price = price;
            Character = character;
        }
    }
}
