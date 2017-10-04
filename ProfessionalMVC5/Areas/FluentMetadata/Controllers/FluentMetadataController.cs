using System.Web.Mvc;
using ProfessionalMVC5.Areas.FluentMetadata.Models;

namespace ProfessionalMVC5.Areas.FluentMetadata.Controllers
{
    public class FluentMetadataController : Controller
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
