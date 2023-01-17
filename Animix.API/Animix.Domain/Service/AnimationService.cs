using Animix.Domain.Interface.Repository;
using Animix.Domain.Interface.Service;
using Animix.Domain.Model.Entity;
using Animix.Domain.Model.Request;
using Animix.Domain.Model.Response;

namespace Animix.Domain.Service
{
    public class AnimationService : IAnimationService
    {
        private readonly IAnimationRepository _animationRepository;

        public AnimationService(IAnimationRepository animationRepository)
        {
            _animationRepository = animationRepository;
        }

        public async Task<ResultService<AnimationResponse>> CreateAnimationAsync(AnimationCreateRequest request)
        {
            if (request == null)
                return ResultService.Fail<AnimationResponse>("O objeto deve ser informado!");

            await using var convertImage = new MemoryStream();
            await request.Image.CopyToAsync(convertImage);

            var animation = new Animation(request.Name, request.Description, convertImage.ToArray());

            var animationCreated = await _animationRepository.CreateAnimationAsync(animation);

            if (animationCreated == null)
                return ResultService.Fail<AnimationResponse>("Problemas para criar a animação!");

            var response = new AnimationResponse(animationCreated.IdAnimation, animationCreated.Name, animationCreated.Description, animationCreated.Image);

            return ResultService.Ok<AnimationResponse>(response);
        }

        public async Task<ResultService> DeleteAnimationAsync(int idAnimation)
        {
            var animationDeleted = await _animationRepository.DeleteAnimationAsync(idAnimation);

            if (animationDeleted == null)
                return ResultService.Fail("Problemas para deletar a animação!");

            return ResultService.Ok("Animação deletada com sucesso!");
        }

        public async Task<ResultService<List<AnimationResponse>>> GetAllAnimationsAsync()
        {
            var animations = await _animationRepository.GetAllAnimationsAsync();

            if (animations == null)
                return ResultService.Fail<List<AnimationResponse>>("Nenhuma animação encontrada!");

            var response = new List<AnimationResponse>();
            foreach (var animation in animations)
            {
                response.Add(new AnimationResponse(animation.IdAnimation, animation.Name, animation.Description, animation.Image));
            }

            return ResultService.Ok<List<AnimationResponse>>(response);
        }

        public async Task<ResultService<AnimationResponse>> GetAnimationByIdAsync(int idAnimation)
        {
            var animation = await _animationRepository.GetAnimationByIdAsync(idAnimation);

            if (animation == null)
                return ResultService.Fail<AnimationResponse>("Nenhuma animação encontrada!");

            var response = new AnimationResponse(animation.IdAnimation, animation.Name, animation.Description, animation.Image);

            return ResultService.Ok<AnimationResponse>(response);
        }

        public async Task<ResultService<AnimationResponse>> UpdateAnimationAsync(AnimationUpdateRequest request)
        {
            if (request == null)
                return ResultService.Fail<AnimationResponse>("O objeto deve ser informado!");

            var animation = await _animationRepository.GetAnimationByIdAsync(request.Id);

            await using var convertImage = new MemoryStream();
            await request.Image.CopyToAsync(convertImage);

            animation.Name = request.Name;
            animation.Description = request.Description;
            animation.Image = convertImage.ToArray();

            var animationUpdated = await _animationRepository.UpdateAnimationAsync(animation);

            if (animationUpdated == null)
                return ResultService.Fail<AnimationResponse>("Problemas para editar a Animação!");

            var response = new AnimationResponse(animationUpdated.IdAnimation, animationUpdated.Name, animationUpdated.Description, animationUpdated.Image);

            return ResultService.Ok<AnimationResponse>(response);
        }
    }
}
