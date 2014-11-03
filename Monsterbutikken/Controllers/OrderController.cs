using System;
using System.Collections.Generic;
using Monsterbutikken.Application;
using Monsterbutikken.ReadLayer.order;

namespace Monsterbutikken.Controllers
{
    public class OrderController : MonsterShopController
    {
        private readonly IBasketApplicationService _basketService;        
        private readonly IOrderApplicationService _orderService;
        private readonly IOrders _orders;
        
        public OrderController(IBasketApplicationService basketService, IOrderApplicationService orderService, IOrders orders)
        {
            _orderService = orderService;            
            _basketService = basketService;
            _orders = orders;
        }

        /**
        * Checks out the customers current basket, creating an order based on the basket contents.
        */
        public void Post()
        {
            _basketService.CheckoutBasket(GetCurrentBasketId(), GetCurrentCustomerId(), Guid.NewGuid().ToString());
            RemoveCurrentBasketId();
        }

        /**
        * Gets all orders placed by the current customer
        *
        * @return List of orders.
        */
        public List<IOrderJson> Get()
        {
            return _orders.GetOrders(GetCurrentCustomerId());
        }

        /**
        * Gets all orders placed by the current customer
        *
        * @return List of orders.
        */
        public IOrderJson Get(string id)
        {
            return _orders.GetOrder(GetCurrentCustomerId(), id);
        }

        /**
        * Cancels an order placed by the current customer
        *
        * @param orderId identifier for the order to be canceled
        */
        public void Delete(string id)
        {
            _orderService.CancelOrder(GetCurrentCustomerId(), id);
        }
       
    }
}
