using Animix.Domain.Model.Validations;
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
        [ForeignKey("FkAnimation")]
        public virtual Animation Animation { get; private set; }
        [ForeignKey("FkOwner")]
        public virtual User? User { get; private set; }
        public virtual Marketplace? Marketplace { get; private set; }
        public virtual List<CharacterTransaction> CharacterTransactions { get; private set; }

        public Character(string name, bool[] image, Animation animation, User? user, Marketplace? marketplace)
        {
            Validation(name: name, image: image, animation: animation);
        }

        public Character(int idCharacter, string name, bool[] image, Animation animation, User? user, Marketplace? marketplace, List<CharacterTransaction> characterTransactions)
        {
            Validation(name : name, image : image, animation : animation);
            DomainValidationException.When(idCharacter < 0, "O id deve ser informado!");
            DomainValidationException.When(characterTransactions == null, "A Lista de transações deve ser informada!");

            IdCharacter = idCharacter;
            User = user;
            Marketplace = marketplace;
            CharacterTransactions = characterTransactions;
        }

        public void Validation(string name, bool[] image, Animation animation)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "O nome deve ser informado!");
            DomainValidationException.When(image == null, "A Imagem deve ser informada!");
            DomainValidationException.When(animation == null, "A Animação deve ser informada!");

            Name = name;
            Image = image;
            Animation = animation;
            CharacterTransactions = new List<CharacterTransaction>();
        }
    }
}
