using System.Web.Mvc;

namespace AddressBook.Controllers
{
	public class HomeController : Controller
	{
		#region Properties

		//
		// GET: /Home/

		public ActionResult Index()
		{
			return View();
		}

		#endregion Properties

		#region Constructors

		public HomeController()
			: base()
		{
		}

		#endregion Constructors
	}
}