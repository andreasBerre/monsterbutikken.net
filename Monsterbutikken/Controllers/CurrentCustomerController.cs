using System;

namespace Monsterbutikken.Controllers
{
    public class CurrentCustomerController : MonsterShopController
    {

        public void Post(String id)
        {
            System.Web.HttpContext.Current.Session["customerName"] = id;
        }
        
        public Customer Get()
        {
            return new Customer
            {
                CustomerName = (string) System.Web.HttpContext.Current.Session["customerName"]
            };
        }

        public void Delete()
        {
            System.Web.HttpContext.Current.Session.Remove("customerName");
        }        

    }

    public class Customer
    {
        public string CustomerName { get; set; }
    }
}
