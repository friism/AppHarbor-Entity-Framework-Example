using System.Web.Mvc;
using EntityFrameworkTest2.Model;

namespace EntityFrameworkTest2.Controllers
{
	public class FooController : Controller
	{
		public ActionResult Index()
		{
			var s = @"metadata=res://*/Model.Model1.csdl|res://*/Model.Model1.ssdl|res://*/Model.Model1.msl;provider=System.Data.SqlClient;provider connection string='Server=ee503428-5b5e-4e78-8592-9fa50063900d.sqlserver.sequelizer.com;Database=dbee5034285b5e4e7885929fa50063900d;User ID=llpfgusfzzkbogea;Password=pXDiwJpCUBBTXPSBeWVHKUtPyChhr3ufFrCuhqY2mhzUu6xok58TAJxBDWS3BhkZ;'";
			var foos = new dbee5034285b5e4e7885929fa50063900dEntities(s).Foos;
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
