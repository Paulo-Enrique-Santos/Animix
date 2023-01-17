using Animix.Domain.Model.Request;
using Animix.Domain.Model.Response;
using Animix.Domain.Service;

namespace Animix.Domain.Interface.Service
{
    public interface ICharacterService
    {
        Task<ResultService<CharacterResponse>> CreateCharacterAsync(CharacterCreateRequest request);
        Task<ResultService> DeleteCharacterAsync(int idCharacter);
        Task<ResultService<CharacterResponse>> GetCharacterByIdAsync(int idCharacter);
        Task<ResultService<List<CharacterResponse>>> GetAllCharacterAsync();
        Task<ResultService<CharacterResponse>> UpdateCharacterAsync(CharacterUpdateRequest request);
    }
}
