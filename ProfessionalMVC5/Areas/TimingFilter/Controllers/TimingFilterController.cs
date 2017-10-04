using System.Threading;
using System.Web.Mvc;
using ProfessionalMVC5.Areas.TimingFilter.Utility;

namespace ProfessionalMVC5.Areas.TimingFilter.Controllers
{
    public class TimingFilterController : Controller
    {
        [ExecutionTiming]
        public ActionResult Index()
        {
            Thread.Sleep(100);
            return View();
        }
    }
}
