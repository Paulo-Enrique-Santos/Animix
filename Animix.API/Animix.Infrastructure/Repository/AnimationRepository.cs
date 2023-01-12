using Animix.Domain.Interface.Repository;
using Animix.Domain.Model.Entity;
using Animix.Infrastructure.Context;

namespace Animix.Infrastructure.Repository
{
    public class AnimationRepository : IAnimationRepository
    {
        private readonly AppDbContext _appDbContext;

        public AnimationRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Animation> CreateAnimationAsync(Animation animation)
        {

        }

        public async Task<string> DeleteAnimationAsync(int idAnimation)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Animation>> GetAllAnimationsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Animation> GetAnimationByIdAsync(int idAnimation)
        {
            throw new NotImplementedException();
        }

        public async Task<Animation> UpdateAnimationAsync(int idAnimation)
        {
            throw new NotImplementedException();
        }
    }
}
