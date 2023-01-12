using Animix.Domain.Model.Entity;
using Animix.Domain.Model.Request;
using Animix.Domain.Service;

namespace Animix.Domain.Interface.Service
{
    public interface IUserService
    {
        Task<ResultService<User>> RegisterUserAsync(UserRegisterRequest request);
    }
}
