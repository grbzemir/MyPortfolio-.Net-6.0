using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class DefaultController : Controller
    {

        //Geriye View Dönememi sağlar!
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
