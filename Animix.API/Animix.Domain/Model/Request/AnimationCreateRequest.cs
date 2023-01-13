using Microsoft.AspNetCore.Http;

namespace Animix.Domain.Model.Request
{
    public class AnimationCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
    }
}
