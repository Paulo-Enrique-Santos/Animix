using Animix.Domain.Interface.Repository;
using Animix.Domain.Model.Entity;
using Animix.Domain.Model.Request;
using Animix.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Animix.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<User> LoginUserAsync(UserLoginRequest userLoginRequest)
        {
            return await _appDbContext.User.FirstOrDefaultAsync(x => x.Email == userLoginRequest.Email && x.Password == userLoginRequest.Password);
        }

        public async Task<User> RegisterUserAsync(User user)
        {
            _appDbContext.User.Add(user);
            await _appDbContext.SaveChangesAsync();
            return user;
        }
    }
}
