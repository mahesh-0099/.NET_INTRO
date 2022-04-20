using EcommerceWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebApp.Controllers
{
    public class HomeController1 : Controller
    {
        EcommerceDbContext _ecommerceDbContext;
        public HomeController1(EcommerceDbContext ecommerceDbContext)
        {
            _ecommerceDbContext = ecommerceDbContext;
        }
        public IActionResult Product()
        {
            return View();
        }
        [HttpGet]
        public IEnumerable<TblProduct> GetCategories()
        {
            return _ecommerceDbContext.TblProducts.ToList();
        }
    }
}
