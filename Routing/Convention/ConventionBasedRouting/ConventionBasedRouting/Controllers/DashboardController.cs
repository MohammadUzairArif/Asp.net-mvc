using Microsoft.AspNetCore.Mvc;

namespace ConventionBasedRouting.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int RouteWithId(int id)
        {
            //later we pass this id to view

            return id;
        }
    }
}
