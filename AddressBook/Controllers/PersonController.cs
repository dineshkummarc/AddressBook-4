using System.Linq;
using System.Web.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
	[ChildActionOnly]
	public class PersonController : Controller
	{
		#region Public

		//
		// GET: /Person/

		public ActionResult Index()
		{
			using (var db = new AddressBookContext())
			{
				var people = db.People.OrderBy(p => p.LastName).ToList();
				return PartialView("_Index", people);
			}
		}

		//
		// GET: /Person/Details/5

		public ActionResult Details(int id)
		{
			using (var db = new AddressBookContext())
			{
				var person = db.People.SingleOrDefault(p => p.Id == id);
				if (person == null)
				{
					return Index();
				}

				return PartialView("_Details", person);
			}
		}

		#endregion Public
	}
}