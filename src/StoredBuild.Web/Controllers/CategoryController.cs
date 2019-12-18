using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoredBuild.Domain.Dto;
using StoredBuild.Domain.Service;
using StoredBuild.Web.Models;

namespace StoredBuild.Web.Controllers
{
    public class CategoryController : Controller
    {
        public CategoryStorerService _categoryStorerService;

        public CategoryController(CategoryStorerService categoryStorerService)
        {
            _categoryStorerService = categoryStorerService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateOrEdit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrEdit(CategoryDto dto)
        {
            return View();
        }

    }
}
