using Microsoft.AspNetCore.Mvc;
using SarayCilingir.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SarayCilingir.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository repository;

        public CategoryController(ICategoryRepository _repository)
        {
            repository = _repository;
        }
        public IActionResult Index()
        {
            return View(repository.GetByName("Barel"));
        }
    }
}
