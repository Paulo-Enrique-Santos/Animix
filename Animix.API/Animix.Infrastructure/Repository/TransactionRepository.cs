using Animix.Domain.Interface.Repository;
using Animix.Domain.Model.Entity;
using Animix.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Animix.Infrastructure.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly AppDbContext _appDbContext;

        public TransactionRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task<CharacterTransaction> SetCharacterTransactionAsync(CharacterTransaction characterTransaction)
        {
            _appDbContext.CharacterTransaction.Add(characterTransaction);
            await _appDbContext.SaveChangesAsync();
            return characterTransaction;
        }

        public async Task<Marketplace> RemoveSaleCharacterAsync(Character character)
        {
            var marketplace = await _appDbContext.Marketplace.FirstOrDefaultAsync(x => x.Character == character);

            _appDbContext.Marketplace.Remove(marketplace);
            await _appDbContext.SaveChangesAsync();
            return marketplace;
        }

        public async Task<Marketplace> SetSaleCharacterAsync(Marketplace marketplace)
        {
            _appDbContext.Marketplace.Add(marketplace);
            await _appDbContext.SaveChangesAsync();
            return marketplace;
        }

        public async Task<UserTransaction> SetUserTransactionAsync(UserTransaction userTransaction)
        {
            _appDbContext.UserTransaction.Add(userTransaction);
            await _appDbContext.SaveChangesAsync();
            return userTransaction;
        }

        public async Task<Marketplace> UpdateSaleCharacterAsync(Marketplace marketplace)
        {
            _appDbContext.Marketplace.Update(marketplace);
            await _appDbContext.SaveChangesAsync();
            return marketplace;
        }

        public async Task<Marketplace> GetMarketplaceByCharacterAsync(Character character)
        {
            return await _appDbContext.Marketplace.FirstOrDefaultAsync(x => x.Character == character);
        }
    }
}
