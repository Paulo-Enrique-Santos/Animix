using Animix.Domain.Interface.Repository;
using Animix.Domain.Interface.Service;
using Animix.Domain.Model.Entity;
using Animix.Domain.Model.Enum;
using Animix.Domain.Model.Request;

namespace Animix.Domain.Service
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IUserRepository _userRepository;
        private readonly ICharacterRepository _characterRepository;

        public TransactionService(ITransactionRepository transactionRepository, IUserRepository userRepository, ICharacterRepository characterRepository)
        {
            _transactionRepository = transactionRepository;
            _userRepository = userRepository;
            _characterRepository = characterRepository;
        }

        public async Task<ResultService> BuyerCharacterAsync(BuyCharacterRequest request)
        {
            if (request == null)
                return ResultService.Fail("O Objeto deve ser informado!");

            var buyer = await _userRepository.GetUserByIdAsync(request.IdBuyer);

            if (buyer == null)
                return ResultService.Fail("Comprador não encontrado!");

            var seller = await _userRepository.GetUserByIdAsync(request.IdSeller);

            if (seller == null)
                return ResultService.Fail("Vendedor não encontrado!");

            var character = await _characterRepository.GetCharacterByIdAsync(request.IdCharacter);

            if (character == null)
                return ResultService.Fail("Personagem não encontrado!");

            if (buyer.Balance < request.Price)
                return ResultService.Fail("Saldo insuficiente para concluir a compra!");

            var characterTransaction = new CharacterTransaction(request.Price, buyer, seller, character);

            await _transactionRepository.BuyCharacterAsync(characterTransaction);

            var buyerTransaction = new UserTransaction(ETransactionType.PURCHASE, request.Price * -1, buyer);

            await _transactionRepository.SetUserTransactionAsync(buyerTransaction);

            var sellerTransaction = new UserTransaction(ETransactionType.SALE, request.Price, seller);

            await _transactionRepository.SetUserTransactionAsync(sellerTransaction);

            buyer.Balance -= request.Price;

            await _userRepository.UpdateUserAsync(buyer);

            seller.Balance += request.Price;

            await _userRepository.UpdateUserAsync(seller);

            await _transactionRepository.RemoveSaleCharacterAsync(character);

            character.User = buyer;

            await _characterRepository.UpdateCharacterAsync(character);

            return ResultService.Ok("Transação concluida com sucesso!");
        }

        public async Task<ResultService<decimal>> DepositValueAsync(DepositRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultService> SaleCharacterAsync(SaleCharacterRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultService> UpdateSalePriceAsync(SaleCharacterRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultService<decimal>> WithdrawValueAsync(DepositRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
