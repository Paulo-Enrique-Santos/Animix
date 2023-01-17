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

        public async Task<ResultService> DeleteCharacterAsync(int idCharacter)
        {
            var characterDeleted = await _characterRepository.DeleteCharacterAsync(idCharacter);

            if (characterDeleted == null)
                return ResultService.Fail("Problemas para deletar a animação!");

            return ResultService.Ok("Animação deletada com sucesso!");
        }

        public async Task<ResultService<List<CharacterResponse>>> GetAllCharacterAsync()
        {
            var characters = await _characterRepository.GetAllCharacterAsync();

            if (characters == null)
                return ResultService.Fail<List<CharacterResponse>>("Nenhum Personagem foi encontrado!");

            var response = new List<CharacterResponse>();
            foreach (var character in characters)
            {
                response.Add(new CharacterResponse(character.IdCharacter, character.Name, character.Image));
            }

            return ResultService.Ok<List<CharacterResponse>>(response);
        }

        public async Task<ResultService<CharacterResponse>> GetCharacterByIdAsync(int idCharacter)
        {
            var character = await _characterRepository.GetCharacterByIdAsync(idCharacter);

            if (character == null)
                return ResultService.Fail<CharacterResponse>("Nenhum Personagem encontrado!");

            var response = new CharacterResponse(character.IdCharacter, character.Name, character.Image);

            return ResultService.Ok<CharacterResponse>(response);
        }

        public async Task<ResultService<CharacterResponse>> UpdateCharacterAsync(CharacterUpdateRequest request)
        {
            if (request == null)
                return ResultService.Fail<CharacterResponse>("O objeto deve ser informado!");

            var character = await _characterRepository.GetCharacterByIdAsync(request.IdCharacter);

            await using var convertImage = new MemoryStream();
            await request.Image.CopyToAsync(convertImage);

            character.Name = request.Name;
            character.Image = convertImage.ToArray();

            var characterUpdated = await _characterRepository.UpdateCharacterAsync(character);

            if (characterUpdated == null)
                return ResultService.Fail<CharacterResponse>("Problemas para editar o Personagem!");

            var response = new CharacterResponse(characterUpdated.IdCharacter, characterUpdated.Name, characterUpdated.Image);

            return ResultService.Ok<CharacterResponse>(response);
        }
    }
}
