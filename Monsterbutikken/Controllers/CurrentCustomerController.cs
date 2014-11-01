using System;
using System.Web.Http;

namespace Monsterbutikken.Controllers
{
    public class CurrentCustomerController : ApiController
    {

        public void Post(String id)
        {
            System.Web.HttpContext.Current.Session["customerName"] = id;
        }
        
        public Customer Get()
        {
            return new Customer
            {
                customerName = (string) System.Web.HttpContext.Current.Session["customerName"]
            };
        }

        public void Delete()
        {
            System.Web.HttpContext.Current.Session.Remove("customerName");
        }        

    }

    public class Customer
    {
        public string customerName { get; set; }
    }
}
