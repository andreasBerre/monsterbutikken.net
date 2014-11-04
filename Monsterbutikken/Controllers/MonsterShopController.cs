using System.Web.Http;

namespace Monsterbutikken.Controllers
{
    public class MonsterShopController : ApiController
    {
        protected string GetCurrentBasketId()
        {
            return (string)System.Web.HttpContext.Current.Session["basketId"];
        }

        protected void SetCurrentBasketId(string basketId)
        {
            System.Web.HttpContext.Current.Session["basketId"] = basketId;     
        }

        protected string GetCurrentCustomerId()
        {
            return (string) System.Web.HttpContext.Current.Session["customerName"];
        }

        protected void SetCurrentCustomerId(string customerId)
        {
            System.Web.HttpContext.Current.Session["customerName"] = customerId;                
        }

        protected void RemoveCurrentCustomerId()
        {
            System.Web.HttpContext.Current.Session.Remove("customerName");
        }
        
        protected void RemoveCurrentBasketId()
        {
            System.Web.HttpContext.Current.Session.Remove("basketId");
        }

    }
}