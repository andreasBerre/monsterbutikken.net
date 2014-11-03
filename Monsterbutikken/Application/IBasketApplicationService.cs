namespace Monsterbutikken.Application
{
    public interface IBasketApplicationService
    {
        void AddItemToBasket(string getCurrentBasketId, string monstertype);
        void RemoveItemFromBasket(string getCurrentBasketId, string id);
        void CreateBasket(string basketId);
        void CheckoutBasket(string getCurrentBasketId, string getCurrentCustomerId, string basketId);
    }
}