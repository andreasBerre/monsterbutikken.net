using System.Collections.Generic;

namespace Monsterbutikken.ReadLayer.basket
{
    public interface IBaskets
    {
        List<IBasketLineItemJson> GetBasketLineItems(string basketId);
    }
}