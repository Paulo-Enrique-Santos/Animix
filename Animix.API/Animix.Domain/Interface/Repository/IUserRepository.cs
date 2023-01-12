using Animix.Domain.Model.Entity;

namespace Animix.Domain.Interface.Repository
{
    public interface IUserRepository
    {
        Task<User> RegisterUserAsync(User user);
    }
}
