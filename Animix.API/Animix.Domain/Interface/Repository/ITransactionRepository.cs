using Animix.Domain.Model.Entity;
using Animix.Domain.Model.Request;

namespace Animix.Domain.Interface.Repository
{
    public interface ITransactionRepository
    {
        Task<CharacterTransaction> BuyCharacterAsync(CharacterTransaction characterTransaction);
        Task<Marketplace> SetSaleCharacterAsync(Marketplace marketplace);
        Task<Marketplace> UpdateSaleCharacterAsync(Marketplace marketplace);
        Task<Marketplace> RemoveSaleCharacterAsync(Character character);
        Task<UserTransaction> SetUserTransactionAsync(UserTransaction userTransaction);
    }
}
