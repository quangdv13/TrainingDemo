using Microsoft.AspNetCore.Mvc;

namespace TrainingFPTCo.Controllers
{
    public class TrainerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
