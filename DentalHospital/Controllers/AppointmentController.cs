using DentalHospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DentalHospital.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        DentalHospitalEntities dentalRecord = new DentalHospitalEntities();
        public ActionResult AppointmentRecord()
        {
            return View(dentalRecord.Appointment_Table.ToList());
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
        public ActionResult Create([Bind(Exclude="id")] Appointment_Table appointment)
        {
            if (!ModelState.IsValid)
                return View();
            dentalRecord.Appointment_Table.Add(appointment);
            dentalRecord.SaveChanges();
            return RedirectToAction("AppointmentRecord");
        }

        // GET: Appointment/Edit/5
        public ActionResult Edit(int id)
        {
            var AppintID= (from m in dentalRecord.Appointment_Table where m.id == id select m).First();
            return View(AppintID);
        }

        // POST: Appointment/Edit/5
        [HttpPost]
        public ActionResult Edit(Appointment_Table appointmentID)
        {
            var orignalRecord = (from m in dentalRecord.Appointment_Table where m.id ==appointmentID.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            dentalRecord.Entry(orignalRecord).CurrentValues.SetValues(appointmentID);

            dentalRecord.SaveChanges();
            return RedirectToAction("AppointmentRecord");

        }

        // GET: Appointment/Delete/5
        public ActionResult Delete(Appointment_Table appointmentID)
        {

            var d = dentalRecord.Appointment_Table.Where(x => x.id == appointmentID.id).FirstOrDefault();
            dentalRecord.Appointment_Table.Remove(d);
            dentalRecord.SaveChanges();
            return RedirectToAction("AppointmentRecord");
        }

        // POST: Appointment/Delete/5
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
