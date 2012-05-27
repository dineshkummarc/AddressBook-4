using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;
using AddressBook.Models;

namespace AddressBook
{
	public class MvcApplication : System.Web.HttpApplication
	{
		#region Public

		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}

		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
					"Default",
					"{controller}/{action}/{id}",
					new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}

		#endregion Public

		#region Non public

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			RegisterGlobalFilters(GlobalFilters.Filters);
			RegisterRoutes(RouteTable.Routes);

			Database.SetInitializer(new AddressBookContextInitializer());
		}

		#endregion Non public
	}
}