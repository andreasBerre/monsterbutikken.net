namespace Monsterbutikken.Application
{
    public interface IOrderApplicationService
    {
        void CancelOrder(string customerId, string orderId);
    }
}