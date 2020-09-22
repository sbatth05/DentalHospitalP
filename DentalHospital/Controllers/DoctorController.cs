using DentalHospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DentalHospital.Controllers
{
    public class DoctorController : Controller
    {

        // GET: Appointment
        DentalHospitalEntities dentalRecord = new DentalHospitalEntities();

        public ActionResult DoctorRecord()
        {
            return View(dentalRecord.Doctor_Table.ToList());
        }

        public ActionResult ourTeam()
        {
            return View(dentalRecord.Doctor_Table.ToList());
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
        public ActionResult Create([Bind(Exclude = "id")] Doctor_Table doctor)
        {
            if (!ModelState.IsValid)
                return View();
            dentalRecord.Doctor_Table.Add(doctor);
            dentalRecord.SaveChanges();
            return RedirectToAction("DoctorRecord");
        }

        // GET: Appointment/Edit/5
        public ActionResult Edit(int id)
        {
            var AppintID = (from m in dentalRecord.Doctor_Table where m.id == id select m).First();
            return View(AppintID);
        }

        // POST: Appointment/Edit/5
        [HttpPost]
        public ActionResult Edit(Doctor_Table doctor)
        {
            var orignalRecord = (from m in dentalRecord.Doctor_Table where m.id == doctor.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            dentalRecord.Entry(orignalRecord).CurrentValues.SetValues(doctor);

            dentalRecord.SaveChanges();
            return RedirectToAction("DoctorRecord");

        }

        // GET: Appointment/Delete/5
        public ActionResult Delete(Doctor_Table doctor)
        {

            var d = dentalRecord.Doctor_Table.Where(x => x.id == doctor.id).FirstOrDefault();
            dentalRecord.Doctor_Table.Remove(d);
            dentalRecord.SaveChanges();
            return RedirectToAction("DoctorRecord");
        }


        // POST: Doctor/Delete/5
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
