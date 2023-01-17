﻿using Animix.Domain.Model.Entity;
using Animix.Domain.Model.Request;
using Animix.Domain.Model.Response;
using Animix.Domain.Service;

namespace Animix.Domain.Interface.Service
{
    public interface IUserService
    {
        Task<ResultService<UserResponse>> RegisterUserAsync(UserRegisterRequest request);
        Task<ResultService<UserResponse>> LoginUserAsync(UserLoginRequest request);
        Task<ResultService<string>> UpdatePasswordAsync(UserForgotPasswordRequest request);
        Task<ResultService<User>> GetUserByIdAsync(int idUser);
    }
}
