using Animix.Domain.Model.Entity;

namespace Animix.Domain.Interface.Repository
{
    public interface IAnimationRepository
    {
        Task<Animation> CreateAnimationAsync(Animation animation);
        Task<List<Animation>> GetAllAnimationsAsync();
        Task<Animation> GetAnimationByIdAsync(int idAnimation);
        Task<Animation> UpdateAnimationAsync(Animation animation);
        Task<Animation> DeleteAnimationAsync(int idAnimation);
    }
}
