namespace Animix.Domain.Model.Response
{
    public class UserResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public UserResponse(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
