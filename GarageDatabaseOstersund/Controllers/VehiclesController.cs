using GarageDatabaseOstersund.Models;
using GarageDatabaseOstersund.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GarageDatabaseOstersund.Controllers
{
    public class VehiclesController : Controller
    {
        VehicleRepository repo = new VehicleRepository();


        public ActionResult Details(string id)
        {
            Vehicle v = repo.GetVehicle(id);
            return View(v);
        }
        // GET: Vehicles
        public ActionResult Index()
        {
            return View(repo.GetAllVehicles());
        }

        // GET: Vehicles
        public ActionResult Create()
        {
            ViewBag.VehicleTypes = repo.GetAllVehicleTypes();
            ViewBag.Owners = new OwnerRepository().getAllOwners();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Vehicle vehicle)
        {
            repo.AddVehicle(vehicle);
            return RedirectToAction("Index");
        }
    }
}