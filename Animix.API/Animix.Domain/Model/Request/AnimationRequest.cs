using Microsoft.AspNetCore.Http;

namespace Animix.Domain.Model.Request
{
    public class AnimationCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
    }

    public class AnimationEditRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
    }
}
