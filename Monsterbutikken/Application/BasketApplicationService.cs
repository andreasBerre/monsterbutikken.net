namespace Monsterbutikken.Application
{
    public class BasketApplicationService : IBasketApplicationService
    {
        public void AddItemToBasket(string getCurrentBasketId, string monstertype)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveItemFromBasket(string getCurrentBasketId, string id)
        {
            throw new System.NotImplementedException();
        }

        public void CreateBasket(string basketId)
        {
            throw new System.NotImplementedException();
        }

        public void CheckoutBasket(string getCurrentBasketId, string getCurrentCustomerId, string basketId)
        {
            throw new System.NotImplementedException();
        }
    }
}