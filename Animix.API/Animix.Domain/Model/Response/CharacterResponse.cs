namespace Animix.Domain.Model.Response
{
    public class CharacterResponse
    {
        public int IdCharacter { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }

        public CharacterResponse(int idCharacter, string name, byte[] image)
        {
            IdCharacter = idCharacter;
            Name = name;
            Image = image;
        }
    }
}
