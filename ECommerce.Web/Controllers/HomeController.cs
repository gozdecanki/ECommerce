using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Web.Controllers
{
    public class HomeController : Controller
    {
        [FilterContext.Log]
        [FilterContext.Auth(Data.Enum.UserTitle.Customer)]
        public IActionResult Index()
        {
            return View();
        }
    }
}