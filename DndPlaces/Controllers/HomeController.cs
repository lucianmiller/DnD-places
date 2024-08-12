using Microsoft.AspNetCore.Mvc;

namespace DndPlaces.Controllers
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