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
                return ResultService.Fail<Animation>("O objeto deve ser informado!");

            await using var convertImage = new MemoryStream();
            await request.Image.CopyToAsync(convertImage);

            var animation = new Animation(request.Name, request.Description, convertImage.ToArray());

            var animationCreated = await _animationRepository.CreateAnimationAsync(animation);

            if (animationCreated == null)
                return ResultService.Fail<Animation>("Problemas para criar a animação!");

            return ResultService.Ok<Animation>(animationCreated);
        }

        public async Task<ResultService<string>> DeleteAnimationAsync(int idAnimation)
        {
            var animationDeleted = await _animationRepository.DeleteAnimationAsync(idAnimation);

            if (animationDeleted == null)
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

        public async Task<ResultService<Animation>> UpdateAnimationAsync(AnimationEditRequest request)
        {
            if (request == null)
                return ResultService.Fail<Animation>("O objeto deve ser informado!");

            var animation = await GetAnimationByIdAsync(request.Id);

            await using var convertImage = new MemoryStream();
            await request.Image.CopyToAsync(convertImage);

            animation.Data.Name = request.Name;
            animation.Data.Description = request.Description;
            animation.Data.Image = convertImage.ToArray();

            var animationUpdated = await _animationRepository.UpdateAnimationAsync(animation.Data);

            if (animationUpdated == null)
                return ResultService.Fail<Animation>("Problemas para editar a Animação!");

            return ResultService.Ok<Animation>(animationUpdated);
        }
    }
}
