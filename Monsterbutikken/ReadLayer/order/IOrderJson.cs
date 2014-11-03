using System.Collections.Generic;

namespace Monsterbutikken.ReadLayer.order
{
    public interface IOrderJson
    {
        string GetTimePlaced();

        double GetTotal();

        List<IOrderLineItemJson> GetLineItems();

        string GetOrderId();

        bool IsCanceled();
    }

    public interface IOrderLineItemJson
    {
        string GetMonsterType();

        int GetQuantity();

        double GetUnitPrice();
    }
}