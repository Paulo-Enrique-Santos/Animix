using Animix.Domain.Model.Request;
using Animix.Domain.Model.Response;
using Animix.Domain.Service;

namespace Animix.Domain.Interface.Service
{
    public interface IAnimationService
    {
        Task<ResultService<AnimationResponse>> CreateAnimationAsync(AnimationCreateRequest request);
        Task<ResultService<List<AnimationResponse>>> GetAllAnimationsAsync();
        Task<ResultService<AnimationResponse>> GetAnimationByIdAsync(int idAnimation);
        Task<ResultService<AnimationResponse>> UpdateAnimationAsync(AnimationUpdateRequest request);
        Task<ResultService> DeleteAnimationAsync(int idAnimation);
    }
}
