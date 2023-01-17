using Animix.Domain.Model.Entity;

namespace Animix.Domain.Interface.Repository
{
    public interface ICharacterRepository
    {
        Task<Character> CreateCharacterAsync(Character character);
        Task<Character> DeleteCharacterAsync(int idCharacter);
        Task<Character> GetCharacterByIdAsync(int idCharacter);
        Task<List<Character>> GetAllCharacterAsync();
        Task<Character> UpdateCharacterAsync(Character character);
    }
}
