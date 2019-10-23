using Microsoft.AspNetCore.Routing;

namespace Penguin.Web.Abstractions.Interfaces
{
    public interface IRouteConfig
    {
        void RegisterRoutes(IRouteBuilder routes);
    }
}