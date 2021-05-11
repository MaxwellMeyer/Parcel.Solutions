using Microsoft.AspNetCore.Mvc;
using Package.Models;
using System.Collections.Generic;

namespace Package.Controllers
{
  public class ParcelController : Controller
  {

    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
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
      return RedirectToAction("Index");
    }

  }
}