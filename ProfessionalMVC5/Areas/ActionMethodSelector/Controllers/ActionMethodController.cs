using System;
using System.Web.Mvc;
using ProfessionalMVC5.Areas.ActionMethodSelector.Utility;

namespace ProfessionalMVC5.Areas.ActionMethodSelector.Controllers
{
    public class ActionMethodController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [AjaxOnly]
        public ActionResult Index(FormCollection unused)
        {
            return Content(String.Format("<p>" + DateTime.Now + "</p>"));
        }
    }
}
