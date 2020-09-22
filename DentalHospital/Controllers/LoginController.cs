using DentalHospital.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DentalHospital.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult SiteLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult checkLogin(Admin login)
        {
            //Pass the data to store the record into the table 

            DataTable tbl = new DataTable();
            Sql db = new Sql();
            tbl = db.Login("select * from Table_Admin where Name='" + login.Name + "'and UserPassword='" + login.Password + "'");

            if (tbl.Rows.Count > 0)
            {
                return View("Right");
            }
            else
            {
                return View("Wrong");
            }



        }

        // GET: Login/Details/5
        public ActionResult Right()
        {
            return View();
        }


        // GET: Login/Details/5
        public ActionResult Wrong()
        {
            return View();
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
