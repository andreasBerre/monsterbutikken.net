using System;
using System.Collections.Generic;
using Monsterbutikken.Application;
using Monsterbutikken.ReadLayer.basket;

namespace Monsterbutikken.Controllers
{
    
    public class BasketController : MonsterShopController
    {
        private readonly IBaskets _baskets;
        private readonly IBasketApplicationService _basketService;

        public BasketController(IBaskets baskets, IBasketApplicationService basketService)
        {
            _baskets = baskets;
            _basketService = basketService;
        }

        /**
        * Gets the current state of a customers basket
        *
        * @return List of basket line items in the current customers basket.
        */
        public List<IBasketLineItemJson> Get()
        {
            return _baskets.GetBasketLineItems(GetCurrentBasketId());
        }

        /**
         * Adds a new monster of a specified type to the customers basket. If there is an existing basket item the number
         * of monsters is incremented, otherwise a new basket item is created.
         *
         * @param monstertype type of monster to be added to the basket
         */
        public void Post(String id)
        {
            if (GetCurrentBasketId() == null)            
                CreateBasket();             
            
            _basketService.AddItemToBasket(GetCurrentBasketId(), id);
        }

        /**
        * Removes a monster from the customers basket. If the resulting number of monsters reaches 0, the basket item is
        * removed.
        *
        * @param monstertype type of monster to be removed from the basket
        */
        public void Delete(String id)
        {         
            _basketService.RemoveItemFromBasket(GetCurrentBasketId(), id);            
        }

        private void CreateBasket()
        {
            var basketId = Guid.NewGuid().ToString();
            _basketService.CreateBasket(basketId);
            SetCurrentBasketId(basketId);
        }
    }
}
