using DentalHospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DentalHospital.Controllers
{
    public class HomeController : Controller
    {
        DentalHospitalEntities dentalRecord = new DentalHospitalEntities();

        public ActionResult Index()
        {
            return View();
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


        public ActionResult QueryRecord()
        {
            

            return View(dentalRecord.Contact_Table.ToList());
        }

        public ActionResult Delete(Contact_Table ContactID)
        {

            var d = dentalRecord.Contact_Table.Where(x => x.id == ContactID.id).FirstOrDefault();
            dentalRecord.Contact_Table.Remove(d);
            dentalRecord.SaveChanges();
            return RedirectToAction("QueryRecord");
        }



        [HttpPost]
        public ActionResult askQuery(Contact contact)
        {
            //Pass the data to store the record into the table 

            Sql db = new Sql();
            db.sendMessage("insert into Contact_Table values('" + contact.Name + "','" + contact.Phone + "','" + contact.Message + "')");
            return View("done");




        }


        public ActionResult done()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}