using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace Monsterbutikken.ReadLayer.basket
{
    public class BasketProjection : IBaskets
    {
        public List<IBasketLineItemJson> GetBasketLineItems(string basketId)
        {
            //TODO: Implement this
            return Enumerable.Empty<IBasketLineItemJson>().ToList<IBasketLineItemJson>();
        }
    }
}