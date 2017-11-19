using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental.Models;
using PagedList;

namespace PPCRental.Controllers
{
    public class SaleController : Controller
    {
        PPCRentalEntities model = new PPCRentalEntities();
        // GET: Sale
        public ActionResult Index()
        {
            //var property = model.PROPERTies.ToList();
            //return View(property);
            return View();
        }
        
        public PartialViewResult Getpaging(int? page)
        {
            var property = model.PROPERTies.ToList();
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return PartialView("Getpaging", property.ToPagedList(pageNumber, pageSize));
        }
    }
}