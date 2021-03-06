using System.Web.Mvc;
using ProfessionalMVC5.Areas.ActionNameSelector.Utility;

namespace ProfessionalMVC5.Areas.ActionNameSelector.Controllers
{
    public class ActionNameController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Product]
        public ActionResult Product(int productId)
        {
            return Content("You asked for product #" + productId);
        }
    }
}
