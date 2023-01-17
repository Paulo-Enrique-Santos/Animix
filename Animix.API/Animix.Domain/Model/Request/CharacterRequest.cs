using Microsoft.AspNetCore.Http;

namespace Animix.Domain.Model.Request
{
    public class CharacterCreateRequest
    {
        public string Name { get; set; }
        public IFormFile Image { get; set; }
        public int IdAnimation { get; set; }
    }

    public class CharacterUpdateRequest
    {
        public int IdCharacter { get; set; }
        public string Name { get; set; }
        public IFormFile Image { get; set; }
    }
}
