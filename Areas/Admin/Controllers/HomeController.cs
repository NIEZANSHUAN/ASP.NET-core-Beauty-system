using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_core_Beauty_system.Areas.Admin.Controllers
{
    [Area("Admin")]//设置域的特性属于Admin的
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
