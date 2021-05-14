using Microsoft.AspNetCore.Mvc;

namespace PierresBakeryInc.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}