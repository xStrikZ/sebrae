using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sebrae.Controllers
{
    public class HomeSController : Controller
    {
        // GET: HomeS
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Empresas()
        {
            return View();
        }

        public ActionResult Consulta()
        {
            return View();
        }
    }
}