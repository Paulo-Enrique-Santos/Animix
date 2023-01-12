using Animix.Domain.Interface.Repository;
using Animix.Domain.Model.Entity;
using Animix.Infrastructure.Context;

namespace Animix.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<User> RegisterUserAsync(User user)
        {
            _appDbContext.Add(user);
            await _appDbContext.SaveChangesAsync();
            return user;
        }
    }
}
