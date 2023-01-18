using Animix.Domain.Model.Entity;
using Animix.Domain.Model.Request;

namespace Animix.Domain.Interface.Repository
{
    public interface ITransactionRepository
    {
        Task<CharacterTransaction> BuyCharacterAsync(CharacterTransaction request);
        Task<Marketplace> SetSaleCharacterAsync(Marketplace request);
        Task<Marketplace> UpdateSaleCharacterAsync(Marketplace request);
        Task<Marketplace> RemoveSaleCharacterAsync(int idCharacter);
        Task<UserTransaction> SetUserTransactionAsync(UserTransaction request);
    }
}
