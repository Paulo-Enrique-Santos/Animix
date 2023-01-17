using Animix.Domain.Model.Entity;
using Animix.Domain.Model.Request;

namespace Animix.Domain.Interface.Repository
{
    public interface IUserRepository
    {
        Task<User> RegisterUserAsync(User user);
        Task<User> LoginUserAsync(UserLoginRequest request);

        Task<User> GetUserByIdAsync(int idUser);

        Task<User> UpdatePasswordAsync(User user);
    }
}
