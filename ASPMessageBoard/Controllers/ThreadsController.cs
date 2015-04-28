using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASPMessageBoard.Data;
using ASPMessageBoard.Models;
using ASPMessageBoard.Services;

namespace ASPMessageBoard.Controllers
{
    public class ThreadsController : Controller
    {
       
        private IThreadService threadService = null;

        public ThreadsController()
        {
            this.threadService = new ThreadService();
        }

        public ActionResult Index()
        {
            var list = this.threadService.GetAll();
            return View(list);
        }

        public ActionResult Create()
        {
            var thread = new Thread();
            return View(thread);
        }

        [HttpPost]
        public ActionResult Create(Thread thread)
        {
            thread.DatePosted = DateTime.Now;
            thread.Username = User.Identity.Name;
            this.threadService.SaveThread(thread);
            return RedirectToAction("Create");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var thread = this.threadService.GetByID(id);
            return View(thread);
        }
    }
}
