using GarageDatabaseOstersund.Models;
using GarageDatabaseOstersund.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GarageDatabaseOstersund.Controllers
{
    public class OwnersController : Controller
    {
        OwnerRepository repo = new OwnerRepository();
        
        // GET: Owners
        public ActionResult Index()
        {
            return View(repo.getAllOwners());
        }

        public ActionResult Details(string id)
        {
            Owner owner = repo.getOwner(id);
            return View(owner);
        }
    }
}