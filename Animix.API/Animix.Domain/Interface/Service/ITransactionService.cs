using Animix.Domain.Model.Request;
using Animix.Domain.Service;

namespace Animix.Domain.Interface.Service
{
    public interface ITransactionService
    {
        Task<ResultService> BuyerCharacterAsync(BuyCharacterRequest request);
        Task<ResultService> SaleCharacterAsync(SaleCharacterRequest request);
        Task<ResultService> UpdateSalePriceAsync(SaleCharacterRequest request);
        Task<ResultService<decimal>> DepositValueAsync(DepositRequest request);
        Task<ResultService<decimal>> WithdrawValueAsync(DepositRequest request);
    }
}
