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
    public class CommentsController : Controller
    {
              
        private ICommentService commentService = null;

        public CommentsController()
        {
            this.commentService = new CommentService();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create(int id)
        {
            return RedirectToAction("Create");
        }

  
    }
}
