using EcommerceWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebApp.Controllers
{
    public class HomeController : Controller
    {
        EcommerceDbContext _ecommerceDbContext;
        public HomeController(EcommerceDbContext ecommerceDbContext)
        {
            _ecommerceDbContext = ecommerceDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        //[HttpGet]
        //public IEnumerable<TblCategory> GetCategories()
        //{
        //    return _ecommerceDbContext.TblCategories.ToList();
        //}
    }
}
