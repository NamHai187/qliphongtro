using Microsoft.AspNetCore.Mvc;

namespace quanliphongtro.Areas.KhachThue.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
