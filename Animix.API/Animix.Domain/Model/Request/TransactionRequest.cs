namespace Animix.Domain.Model.Request
{
    public class BuyCharacterRequest
    {
        public int IdBuyer { get; set; }
        public int IdSeller { get; set; }
        public int IdCharacter { get; set; }
        public decimal Price { get; set; }
    }

    public class BalanceRequest
    {
        public int IdUser { get; set; }
        public int Value { get; set; }
    }

    public class SaleCharacterRequest
    {
        public int IdCharacter { get; set; }
        public decimal Price { get; set; }
    }
}
