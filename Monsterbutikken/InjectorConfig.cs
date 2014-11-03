using System.Web.Http;
using Monsterbutikken.Application;
using Monsterbutikken.ReadLayer.basket;
using Monsterbutikken.ReadLayer.order;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;

namespace Monsterbutikken
{
    public class InjectorConfig
    {
        public static void Configure()
        {
            //TODO: This would probably be a good place to inject the event store into the services and projections
            var container = new Container();
            
            container.Register<IBasketApplicationService, BasketApplicationService>();            
            container.Register<IOrderApplicationService, OrderApplicationService>();

            container.Register<IBaskets, BasketProjection>();
            container.Register<IOrders, OrdersProjection>();
         
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);         
        }
    }


}