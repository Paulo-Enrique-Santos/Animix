namespace Animix.Domain.Model.Response
{
    public class AnimationResponse
    {
        public int IdAnimation { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }

        public AnimationResponse(int idAnimation, string name, string description, byte[] image)
        {
            IdAnimation = idAnimation;
            Name = name;
            Description = description;
            Image = image;
        }
    }
}
