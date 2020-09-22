using DentalHospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DentalHospital.Controllers
{
    public class PatientController : Controller
    {

        // GET: Appointment
        DentalHospitalEntities dentalRecord = new DentalHospitalEntities();

        public ActionResult PatientRecord()
        {
            return View(dentalRecord.Patient_Details.ToList());
        }

        // GET: Appointment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Appointment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Appointment/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "id")] Patient_Details patient)
        {
            if (!ModelState.IsValid)
                return View();
            dentalRecord.Patient_Details.Add(patient);
            dentalRecord.SaveChanges();
            return RedirectToAction("PatientRecord");
        }

        // GET: Appointment/Edit/5
        public ActionResult Edit(int id)
        {
            var patentID = (from m in dentalRecord.Patient_Details where m.id == id select m).First();
            return View(patentID);
        }

        // POST: Appointment/Edit/5
        [HttpPost]
        public ActionResult Edit(Patient_Details patient)
        {
            var orignalRecord = (from m in dentalRecord.Patient_Details where m.id == patient.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            dentalRecord.Entry(orignalRecord).CurrentValues.SetValues(patient);

            dentalRecord.SaveChanges();
            return RedirectToAction("PatientRecord");

        }

        // GET: Appointment/Delete/5
        public ActionResult Delete(Patient_Details patient)
        {

            var d = dentalRecord.Patient_Details.Where(x => x.id ==patient.id).FirstOrDefault();
            dentalRecord.Patient_Details.Remove(d);
            dentalRecord.SaveChanges();
            return RedirectToAction("PatientRecord");
        }



        // POST: Patient/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
