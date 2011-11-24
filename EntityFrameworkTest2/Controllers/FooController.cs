using System.Web.Mvc;
using EntityFrameworkTest2.Model;

namespace EntityFrameworkTest2.Controllers
{
	public class FooController : Controller
	{
		public ActionResult Index()
		{
			var foos = new dbee5034285b5e4e7885929fa50063900dEntities().Foos;
			return View(foos);
		}

		public ActionResult New()
		{
			return View();
		}

		public ActionResult Create(Foo foo)
		{
			var blah = new dbee5034285b5e4e7885929fa50063900dEntities();
			blah.Foos.AddObject(foo);
			blah.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
