using Animix.Domain.Model.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Animix.Domain.Model.Entity
{
    [Table("animacao")]
    public class Animation
    {
        private Animation() { }
        [Key]
        public int IdAnimation { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public byte[] Image { get; private set; }
        public virtual List<Character> Characters { get; private set; }

        public Animation(string name, string description, byte[] image)
        {
            Validation(name: name, description: description, image: image);
        }

        public Animation(int idAnimation, string name, string description, byte[] image, List<Character> characters)
        {
            Validation(name : name, description : description, image : image);
            DomainValidationException.When(idAnimation < 0, "O id deve ser informado!");
            DomainValidationException.When(characters == null, "A lista de personagens deve ser informada!");

            IdAnimation = idAnimation;
            Characters = characters;
        }

        public void Validation(string name, string description, byte[] image)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "O nome deve ser informado!");
            DomainValidationException.When(string.IsNullOrEmpty(description), "A descrição deve ser informada!");
            DomainValidationException.When(image == null, "A imagem deve ser informada!");

            Name = name;
            Description = description;
            Image = image;
            Characters = new List<Character>();
        }
    }
}
