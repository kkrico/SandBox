using System.Web.Mvc;
using ProfessionalMVC5.Areas.BasicAuthenticationFilter.Models;
using ProfessionalMVC5.Areas.BasicAuthenticationFilter.Utility;

namespace ProfessionalMVC5.Areas.BasicAuthenticationFilter.Controllers
{
    public class BasicAuthenticationFilterController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [BasicAuthentication(Password = "secret")]
        [Authorize]
        public ActionResult Authenticated()
        {
            User model = new User { Name = User.Identity.Name };
            return View(model);
        }
    }
}