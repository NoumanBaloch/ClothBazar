﻿using ClothBazar.Services;
using ClothBazar.Web.ViewModels;
using System.Web.Mvc;

namespace ClothBazar.Web.Controllers
{
    public class HomeController : Controller
    {
        //CategoriesService categoriesService = new CategoriesService();

        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.FeaturedCategories = CategoriesService.Instance.GetFeaturedCategories();



            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}