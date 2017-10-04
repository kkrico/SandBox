using System.Web.Mvc;
using ProfessionalMVC5.Areas.FluentValidation.Models;

namespace ProfessionalMVC5.Areas.FluentValidation.Controllers
{
    public class FluentValidationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            return View(contact);
        }
    }
}
