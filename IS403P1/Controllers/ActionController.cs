using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS403P1.Controllers
{
    public class ActionController : Controller
    {
        // GET: Action
        public ActionResult Index()
        {
            return View();
        }
    }
}