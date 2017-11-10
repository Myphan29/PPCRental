using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental.Models;

namespace PPCRental.Controllers
{
    public class PropertyController : Controller
    {
        PPCRentalDBEntities model = new PPCRentalDBEntities();
        // GET: /Property/
        public ActionResult Detail(int id)
        {
            var property = model.PROPERTies.FirstOrDefault(x => x.ID == id);
            return View(property);
        }
	}
}