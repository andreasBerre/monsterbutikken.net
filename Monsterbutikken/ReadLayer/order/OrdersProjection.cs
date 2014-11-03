using System.Collections.Generic;

namespace Monsterbutikken.ReadLayer.order
{
    public class OrdersProjection : IOrders
    {
        public List<IOrderJson> GetOrders(string customerId)
        {
            throw new System.NotImplementedException();
        }

        public IOrderJson GetOrder(string getCurrentCustomerId, string id)
        {
            throw new System.NotImplementedException();
        }
    }
}