using Animix.Domain.Model.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Animix.Domain.Model.Entity
{
    [Table("personagem")]
    public class Character
    {
        private Character() { }
        [Key]
        public int IdCharacter { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        [ForeignKey("FkAnimation")]
        public virtual Animation Animation { get; set; }
        [ForeignKey("FkOwner")]
        public virtual User? User { get; set; }
        public virtual Marketplace? Marketplace { get; set; }
        public virtual List<CharacterTransaction> CharacterTransactions { get; private set; }

        public Character(string name, byte[] image, Animation animation)
        {
            Validation(name: name, image: image, animation: animation);
        }

        public Character(int idCharacter, string name, byte[] image, Animation animation, User? user, Marketplace? marketplace, List<CharacterTransaction> characterTransactions)
        {
            Validation(name : name, image : image, animation : animation);
            DomainValidationException.When(idCharacter < 0, "O id deve ser informado!");

            IdCharacter = idCharacter;
            User = user;
            Marketplace = marketplace;
            if (characterTransactions != null)
                CharacterTransactions = characterTransactions;
        }

        public void Validation(string name, byte[] image, Animation animation)
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
