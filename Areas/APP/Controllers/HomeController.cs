using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_core_Beauty_system.Areas.APP.Controllers
{
    [Area("APP")]//设置域的特性属于APP的
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
