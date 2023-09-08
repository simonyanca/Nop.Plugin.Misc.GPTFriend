
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.Routing;

namespace Nop.Plugin.Misc.GPTFriend.Infrastructure
{
    /// <summary>
    /// Represents plugin route provider
    /// </summary>
    public class RouteProvider : IRouteProvider
    {
        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="endpointRouteBuilder">Route builder</param>
        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            //endpointRouteBuilder.MapControllerRoute("Redirections", "Admin/GPTFriend/GetRedirections/",
            //new { controller = "GPTFriend", action = "GetRedirections" });
            //endpointRouteBuilder.MapControllerRoute("Redirections", "Admin/GPTFriend/RedirectUpdate/",
            //new { controller = "GPTFriend", action = "RedirectUpdate" });
            //endpointRouteBuilder.MapControllerRoute("Redirections", "Admin/GPTFriend/RedirectRemove/",
            //new { controller = "GPTFriend", action = "RedirectRemove" });

        }

        /// <summary>
        /// Gets a priority of route provider
        /// </summary>
        public int Priority => 0;
    }
}
