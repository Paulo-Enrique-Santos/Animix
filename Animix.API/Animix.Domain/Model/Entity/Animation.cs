using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Animix.Domain.Model.Entity
{
    [Table("animacao")]
    public class Animation
    {
        [Key]
        public int IdAnimation { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool[] Image { get; private set; }
        public virtual List<Character> Characters { get; private set; }
    }
}
