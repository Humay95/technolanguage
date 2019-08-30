using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TexnoGallery.ViewModel.Default;
using TexnoGallery.Models;
namespace TexnoGallery.Controllers
{
    public class HomeController : Controller
    {
        texnoEntities db = new texnoEntities();
        
        public ActionResult Index()
        {

            var defaultModel = new DefaultViewModel
            {
                SlideImage = db.Slides.ToList(),
                CategoryImage = db.ImageCategories.ToList(),
                BrendPhoto = db.Brends.ToList(),
                CategoryName = db.Categories.ToList(),
                productList = db.Products.OrderByDescending(pr => pr.Id).Take(10).ToList(),
            };
            return View(defaultModel);
        }

        public ActionResult About()
        {
            var defaultModel = new DefaultViewModel
            {
                aboutTech = db.AboutUs.Find(1)

            };
            return View(defaultModel);
        }
        public ActionResult Contact()
        {
            var defaultModel = new DefaultViewModel
            {
                contactTech = db.Contacts.Find(1)
            };
            return View(defaultModel);
        }
    }
}