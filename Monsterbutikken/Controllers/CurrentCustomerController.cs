using System;

namespace Monsterbutikken.Controllers
{
    public class CurrentCustomerController : MonsterShopController
    {

        public void Post(String id)
        {
            SetCurrentCustomerId(id);
        }  

        public Customer Get()
        {
            return new Customer
            {
                CustomerName = GetCurrentCustomerId()
            };
        }

        public void Delete()
        {
            RemoveCurrentCustomerId();
        }        

    }

    public class Customer
    {
        public string CustomerName { get; set; }
    }
}
