using Animix.Domain.Interface.Repository;
using Animix.Domain.Model.Entity;
using Animix.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

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
            _appDbContext.Animation.Add(animation);
            await _appDbContext.SaveChangesAsync();
            return animation;
        }

        public async Task<Animation> DeleteAnimationAsync(int idAnimation)
        {
            var animation = await GetAnimationByIdAsync(idAnimation);

            _appDbContext.Animation.Remove(animation);
            await _appDbContext.SaveChangesAsync();

            return animation;
        }

        public async Task<List<Animation>> GetAllAnimationsAsync()
        {
            return await _appDbContext.Animation.ToListAsync();
        }

        public async Task<Animation> GetAnimationByIdAsync(int idAnimation)
        {
            return await _appDbContext.Animation.FirstOrDefaultAsync(x => x.IdAnimation == idAnimation);
        }

        public async Task<Animation> UpdateAnimationAsync(Animation animation)
        {
            throw new NotImplementedException();
        }
    }
}
