namespace Animix.Domain.Model.Response
{
    public class UserResponse
    {
        public int IdUser { get; set; }
        public string Name { get; set; }

        public UserResponse(int idUser, string name)
        {
            IdUser = idUser;
            Name = name;
        }
    }
}
