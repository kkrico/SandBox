using System.Web.Mvc;
using ProfessionalMVC5.Areas.CustomActionResult.Models;
using ProfessionalMVC5.Areas.CustomActionResult.Utility;

namespace ProfessionalMVC5.Areas.CustomActionResult.Controllers
{
    public class CustomActionResultController : Controller
    {
        public ActionResult Index()
        {
            var model = new Person
            {
                FirstName = "Brad",
                LastName = "Wilson",
                Blog = "http://bradwilson.typepad.com"
            };

            return new XmlResult(model);
        }
    }
}
