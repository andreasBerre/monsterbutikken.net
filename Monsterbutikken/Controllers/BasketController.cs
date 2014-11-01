using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Monsterbutikken.Controllers
{
    public class BasketController : ApiController
    {
        /**
     * Gets the current state of a customers basket
     *
     * @return Map of String monsterType og basketItem for the applicable monster type.
     */
    public IDictionary<String, BasketItem> Get(){
        return null;
    }


    }

    public class BasketItem
    {
    }
}
