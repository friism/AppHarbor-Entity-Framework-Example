using System.Web.Mvc;
using System.Configuration;
using EntityFrameworkTest2.Model;

namespace EntityFrameworkTest2.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			//var cs = ConfigurationManager.ConnectionStrings["dbee5034285b5e4e7885929fa50063900dEntities"].ConnectionString;
			var cs = new dbee5034285b5e4e7885929fa50063900dEntities().Connection.ConnectionString;
			return View((object)cs);
		}
	}
}
