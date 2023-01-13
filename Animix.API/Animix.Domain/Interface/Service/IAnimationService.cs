using Animix.Domain.Model.Entity;
using Animix.Domain.Model.Request;
using Animix.Domain.Service;

namespace Animix.Domain.Interface.Service
{
    public interface IAnimationService
    {
        Task<ResultService<Animation>> CreateAnimationAsync(AnimationCreateRequest request);
        Task<ResultService<List<Animation>>> GetAllAnimationsAsync();
        Task<ResultService<Animation>> GetAnimationByIdAsync(int idAnimation);
        Task<ResultService<Animation>> UpdateAnimationAsync(AnimationEditRequest request);
        Task<ResultService<string>> DeleteAnimationAsync(int idAnimation);
    }
}
