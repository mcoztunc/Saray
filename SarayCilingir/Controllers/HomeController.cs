using Microsoft.AspNetCore.Mvc;
using SarayCilingir.Entity;
using SarayCilingir.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SarayCilingir.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository repository;
        private IUnitofWork unitofwork;
        public HomeController(IUnitofWork _unitofwork,IProductRepository _repository)
        {
            repository = _repository;
            unitofwork = _unitofwork;
        }

        public IActionResult Index()
        {
            

            return View(unitofwork.Products.GetAll());
        }

        public IActionResult Details(int id)
        {
            return View(repository.Get(id));
        }


        public IActionResult Create()
        {
            var prd = new Product() { 
             ProductName="Yeni Ürün", Price=1000
            
            
            };
            unitofwork.Products.Add(prd);
            unitofwork.SaveChanges();
            return RedirectToAction("Index");




        }
    }
}
