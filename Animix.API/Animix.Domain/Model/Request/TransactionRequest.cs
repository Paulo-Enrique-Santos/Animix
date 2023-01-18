namespace Animix.Domain.Model.Request
{
    public class BuyCharacterRequest
    {
        public int IdBuyer { get; set; }
        public int IdSeller { get; set; }
        public int IdCharacter { get; set; }
        public decimal Price { get; set; }
    }

    public class DepositRequest
    {
        public int IdUser { get; set; }
        public int Value { get; set; }
    }

    public class WithdrawRequest
    {
        public int IdUser { get; set; }
        public int Value { get; set; }
    }

    public class SaleCharacterRequest
    {
        public int IdUser { get; set; }
        public int IdCharacter { get; set; }
        public decimal Price { get; set; }
    }
}
