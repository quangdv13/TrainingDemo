using Microsoft.AspNetCore.Mvc;

namespace TrainingFPTCo.Controllers
{
    public class TraineeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
