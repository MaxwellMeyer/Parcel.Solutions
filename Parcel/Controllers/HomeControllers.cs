using Microsoft.AspNetCore.Mvc;
using Package.Models;

namespace Package.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      Parcel starterParcel = new Parcel("Add first Parcel to List");
      return View(starterParcel);
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(string description)
    {
      Parcel myParcel = new Parcel(description);
      return View("Index", myParcel);
    }

  }
}
