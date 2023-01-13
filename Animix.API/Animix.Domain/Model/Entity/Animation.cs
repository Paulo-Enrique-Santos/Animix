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
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public virtual List<Character> Characters { get; private set; }

        public Animation(string name, string description, byte[] image)
        {
            Validation(name: name, description: description, image: image);
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
