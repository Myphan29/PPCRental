using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental.Models;
using PagedList;


namespace PPCRental.Controllers
{
    public class HomeController : Controller
    {
      
        PPCRentalDBEntities model = new PPCRentalDBEntities();

        public ActionResult Index()
        {
            //var property = model.PROPERTies.ToList();
            //return View(property);
            return View();
        }
        public PartialViewResult Getpaging(int? page)
        {
            var property = model.PROPERTies.ToList();
            int pageSize = 4;
            int pageNumber = (page ?? 1);
            return PartialView("_PartialViewProperty",property.ToPagedList(pageNumber,pageSize));
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Search(string text)
        {
            var property= model.PROPERTies.ToList().Where(x => x.PropertyName.Contains(text)
                || x.Content.Contains(text) || x.Price.ToString().Contains(text));
            return View(property);

        }

        
       
        
    }
}