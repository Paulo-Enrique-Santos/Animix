using Animix.Domain.Interface.Repository;
using Animix.Domain.Interface.Service;
using Animix.Domain.Model.Entity;
using Animix.Domain.Model.Request;
using Animix.Domain.Model.Response;

namespace Animix.Domain.Service
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository _characterRepository;
        private readonly IAnimationRepository _animationRepository;

        public CharacterService(ICharacterRepository characterRepository, IAnimationRepository animationRepository)
        {
            _characterRepository = characterRepository;
            _animationRepository = animationRepository;
        }

        public async Task<ResultService<CharacterResponse>> CreateCharacterAsync(CharacterCreateRequest request)
        {
            if (request == null)
                return ResultService.Fail<CharacterResponse>("O objeto deve ser informado!");

            await using var convertImage = new MemoryStream();
            await request.Image.CopyToAsync(convertImage);

            var animation = await _animationRepository.GetAnimationByIdAsync(request.IdAnimation);

            if (animation == null)
                return ResultService.Fail<CharacterResponse>("Nenhuma animação encontrada com esse id!");

            var character = new Character(request.Name, convertImage.ToArray(), animation);

            var characterCreated = await _characterRepository.CreateCharacterAsync(character);

            if (characterCreated == null)
                return ResultService.Fail<CharacterResponse>("Problemas para criar o Personagem!");

            var response = new CharacterResponse(characterCreated.IdCharacter, characterCreated.Name, characterCreated.Image);

            return ResultService.Ok<CharacterResponse>(response);
        }

        public Task<ResultService> DeleteCharacterAsync(int idCharacter)
        {
            throw new NotImplementedException();
        }

        public Task<ResultService<List<CharacterResponse>>> GetAllCharacterAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResultService<CharacterResponse>> GetCharacterByIdAsync(int idCharacter)
        {
            throw new NotImplementedException();
        }

        public Task<ResultService<CharacterResponse>> UpdateCharacterAsync(CharacterUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
