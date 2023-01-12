using Animix.Domain.Interface.Repository;
using Animix.Domain.Interface.Service;
using Animix.Domain.Model.Entity;
using Animix.Domain.Model.Request;

namespace Animix.Domain.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepostiory;

        public UserService(IUserRepository userRepostiory)
        {
            _userRepostiory = userRepostiory;
        }

        public async Task<ResultService<User>> RegisterUserAsync(UserRegisterRequest request)
        {
            if (request == null)
                return ResultService.Fail<User>("A request deve ser informada!");

            var validation = new UserRegisterRequestValidation().Validate(request);

            if (!validation.IsValid)
                return ResultService.RequestError<User>("Problemas para fazer o cadastro\n", validation);

            var user = new User(request.Name, request.NickName, request.Email, request.Password);

            var response = await _userRepostiory.RegisterUserAsync(user);

            return ResultService.Ok<User>(response);
        }   
    }
}
