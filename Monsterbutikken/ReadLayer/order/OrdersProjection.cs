using System.Collections.Generic;
using System.Linq;
using Monsterbutikken.ReadLayer.basket;

namespace Monsterbutikken.ReadLayer.order
{
    public class OrdersProjection : IOrders
    {
        public List<IOrderJson> GetOrders(string customerId)
        {
            //TODO: Implement this
            return Enumerable.Empty<IOrderJson>().ToList<IOrderJson>();
        }

        public IOrderJson GetOrder(string getCurrentCustomerId, string id)
        {
            //TODO: Implement this
            return null;
        }
    }
}