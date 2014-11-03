using System.Collections.Generic;

namespace Monsterbutikken.ReadLayer.order
{
    public interface IOrders
    {
        List<IOrderJson> GetOrders(string customerId);
        IOrderJson GetOrder(string getCurrentCustomerId, string id);
    }
}