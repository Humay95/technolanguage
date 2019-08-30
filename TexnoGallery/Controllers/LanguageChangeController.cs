using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace TexnoGallery.Controllers
{
    public class LanguageChangeController : Controller
    {
        // GET: LanguageChange
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Change(string Lang)
        {
            if (Lang != null)
            {
                Thread.CurrentThread.CurrentCulture=CultureInfo.CreateSpecificCulture(Lang);
                Thread.CurrentThread.CurrentCulture = new CultureInfo(Lang);
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("az");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("az");
            }
            Response.Cookies.Add(new HttpCookie("language")
            {
                Value = Lang
            });
            return RedirectToAction ("Index","Home");
        }
    }
}