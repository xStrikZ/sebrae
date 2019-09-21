using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sebrae.Controllers
{
    public class _BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;

            if ((Session["Id"] == null || Session["Id"].ToString() == ""))
            {
                filterContext.Result = new RedirectResult("/Home/LoginPage");
                return;
            }

            base.OnActionExecuting(filterContext);
        }
    }
}