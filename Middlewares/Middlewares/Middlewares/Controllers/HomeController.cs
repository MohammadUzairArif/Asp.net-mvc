using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Middlewares.Models;

namespace Middlewares.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        // GET api/hello
        [HttpGet]
        public string Hello()
        {
            return " Hello from Controller!";
        }
    }
}
