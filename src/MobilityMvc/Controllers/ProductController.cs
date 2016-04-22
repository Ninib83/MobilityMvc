using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MobilityMvc.Models;
using MobilityMvc.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MobilityMvc.Controllers
{
    public class ProductController : Controller
    {
            DataManager dataManager;

            public ProductController(ProductContext context)
            {
                dataManager = new DataManager(context);
            }

            public IActionResult Index()
            {
                var products = dataManager.ListProduct();

                return View(products);

            }

            public IActionResult PartialDescription(int id)
            {

                Product product = dataManager.GetById(id);

                return PartialView("_DescriptionBox", product);
            }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateProductViewModel createProduct)
        {
            if (ModelState.IsValid)
            {
                dataManager.Create(createProduct);

                TempData["Message"] = "En ny produkt är skapad";

                return RedirectToAction("Index");

            }

            return View(createProduct);
        }


    ////[Route("Edit/{id:int}")]
    //[HttpGet]
    //public IActionResult Edit(int id)
    //{
    //    var art = dataManager.Edit(id);

    //    return View(art);
    //}


    //[ValidateAntiForgeryToken]
    //[HttpPost]
    //public ActionResult Edit(EditingArtistViewModel editArtist)
    //{
    //    if (ModelState.IsValid)
    //    {

    //        dataManager.Uppdate(editArtist);

    //        TempData["Message"] = "Uppdateringen Lyckades";

    //        return RedirectToAction("Index");

    //    }
    //    return View(editArtist);
    //}

    //public IActionResult Delete(int id)
    //{
    //    dataManager.Delete(id);

    //    return RedirectToAction("Index");
    //}


}
    }
