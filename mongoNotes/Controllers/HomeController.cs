using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mongoNotes.Models;
using System.Configuration;

namespace mongoNotes.Controllers
{
    public class HomeController : Controller, IDisposable
    {
        private Dal dal = new Dal();
        private bool disposed = false;
        //
        // GET: /Task/

        public ActionResult Index()
        {
            return View(dal.GetAllNotes());
        }

        //
        // GET: /Task/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Task/Create

        [HttpPost]
        public ActionResult Create(Note note)
        {
            try
            {
                dal.CreateNote(note);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult About()
        {
            return View();
        }

        # region IDisposable

        protected new void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected new virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.dal.Dispose();
                }
            }

            this.disposed = true;
        }

        # endregion

    }
}