using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TexnoGallery.ViewModel.Default;
using TexnoGallery.Models;
namespace TexnoGallery.Controllers
{
    public class ProductController : Controller
    {
        texnoEntities db = new texnoEntities();
        // GET: Product
        public ActionResult Product()
        {
            var defaultModel = new DefaultViewModel
            {
                CategoryName = db.Categories.ToList(),
                SubCategoryName = db.SubCategories.ToList()
            };
            return View();
        }
        public ActionResult PcTopla()
        {
            return View();
        }
    }
}
   