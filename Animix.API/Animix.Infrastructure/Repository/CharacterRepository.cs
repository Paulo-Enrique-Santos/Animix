using Animix.Domain.Interface.Repository;
using Animix.Domain.Model.Entity;
using Animix.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Animix.Infrastructure.Repository
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly AppDbContext _appDbContext;

        public CharacterRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Character> CreateCharacterAsync(Character character)
        {
            _appDbContext.Character.Add(character);
            await _appDbContext.SaveChangesAsync();
            return character;
        }

        public async Task<Character> DeleteCharacterAsync(int idCharacter)
        {
            var character = await GetCharacterByIdAsync(idCharacter);

            _appDbContext.Character.Remove(character);
            await _appDbContext.SaveChangesAsync();

            return character;
        }

        public async Task<List<Character>> GetAllCharacterAsync()
        {
            return await _appDbContext.Character.ToListAsync();
        }

        public async Task<Character> GetCharacterByIdAsync(int idCharacter)
        {
            return await _appDbContext.Character.FirstOrDefaultAsync(x => x.IdCharacter == idCharacter);
        }

        public async Task<Character> UpdateCharacterAsync(Character character)
        {
            _appDbContext.Character.Update(character);
            await _appDbContext.SaveChangesAsync();
            return character;
        }
    }
}
