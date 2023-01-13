using Animix.Domain.Interface.Repository;
using Animix.Domain.Interface.Service;
using Animix.Domain.Model.Entity;
using Animix.Domain.Model.Request;

namespace Animix.Domain.Service
{
    public class AnimationService : IAnimationService
    {
        private readonly IAnimationRepository _animationRepository;

        public AnimationService(IAnimationRepository animationRepository)
        {
            _animationRepository = animationRepository;
        }

        public async Task<ResultService<Animation>> CreateAnimationAsync(AnimationCreateRequest request)
        {
            if (request == null)
                ResultService.Fail<Animation>("O objeto deve ser informado!");

            await using var convertImage = new MemoryStream();
            await request.Image.CopyToAsync(convertImage);

            var animation = new Animation(request.Name, request.Description, convertImage.ToArray());

            var response = await _animationRepository.CreateAnimationAsync(animation);

            return ResultService.Ok<Animation>(response);
        }

        public async Task<ResultService<string>> DeleteAnimationAsync(int idAnimation)
        {
            var animation = await _animationRepository.DeleteAnimationAsync(idAnimation);

            if (animation == null)
                return ResultService.Fail<string>("Problemas para deletar a animação!");

            return ResultService.Ok<string>("Animação deletada com sucesso!");
        }

        public async Task<ResultService<List<Animation>>> GetAllAnimationsAsync()
        {
            var animations = await _animationRepository.GetAllAnimationsAsync();

            if (animations == null)
                return ResultService.Fail<List<Animation>>("Nenhuma animação encontrada!");

            return ResultService.Ok<List<Animation>>(animations);
        }

        public async Task<ResultService<Animation>> GetAnimationByIdAsync(int idAnimation)
        {
            var animation = await _animationRepository.GetAnimationByIdAsync(idAnimation);

            if (animation == null)
                return ResultService.Fail<Animation>("Nenhuma animação encontrada!");

            return ResultService.Ok<Animation>(animation);
        }

        public async Task<ResultService<Animation>> UpdateAnimationAsync(int idAnimation)
        {
            throw new NotImplementedException();
        }
    }
}
