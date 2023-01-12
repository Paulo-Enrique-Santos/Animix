using Animix.Domain.Interface.Repository;
using Animix.Domain.Interface.Service;
using Animix.Domain.Model.Entity;
using Animix.Domain.Model.Request;
using Animix.Domain.Model.Response;

namespace Animix.Domain.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepostiory;

        public UserService(IUserRepository userRepostiory)
        {
            _userRepostiory = userRepostiory;
        }

        public async Task<ResultService<UserResponse>> LoginUserAsync(UserLoginRequest request)
        {
            if (request == null)
                return ResultService.Fail<UserResponse>("Os dados do login deve ser informado!");

            var login = await _userRepostiory.LoginUserAsync(request);

            if (login == null)
                return ResultService.Fail<UserResponse>("Email ou Senha incorretos!");

            var response = new UserResponse(login.IdUser, login.Name);

            return ResultService.Ok<UserResponse>(response);
        }

        public async Task<ResultService<UserResponse>> RegisterUserAsync(UserRegisterRequest request)
        {
            if (request == null)
                return ResultService.Fail<UserResponse>("Os dados do usuario deve ser informado!");

            var user = new User(request.Name, request.NickName, request.Email, request.Password);

            var register = await _userRepostiory.RegisterUserAsync(user);

            if (register == null)
                return ResultService.Fail<UserResponse>("Problemas para efetuar o cadastro!");

            var response = new UserResponse(register.IdUser, register.Name);

            return ResultService.Ok<UserResponse>(response);
        }   
    }
}
