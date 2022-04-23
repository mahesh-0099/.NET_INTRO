using EcommerceWebApp.Models;
using EcommerceWebApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebApp.Controllers
{
    public class RegisterController : Controller
    {
        ShoppingCartT4Context _ecommerceDbContext;
        public RegisterController(EcommerceDbContext ecommerceDbContext)
        {
            _ecommerceDbContext = ecommerceDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SubmitData(Register register)
        {
            TblUserDetail tblUserDetail = new TblUserDetail();
            tblUserDetail.FirstName = register.FirstName;
            tblUserDetail.LastName = register.LastName;
            tblUserDetail.Gender = register.Gender;
            tblUserDetail.Email= register.Email;
            tblUserDetail.CreatedOn = DateTime.Now;
            _ecommerceDbContext.TblUserDetails.Add(tblUserDetail);
            _ecommerceDbContext.SaveChanges();
            TblUser tblUser = new TblUser();


            tblUser.CreatedOn = tblUser.CreatedOn;
            tblUser.IsDeleted = 0;
            tblUser.UpdatedOn = DateTime.Now;
            tblUser.UserName = register.Email;
            tblUser.Password = register.FirstName;
            _ecommerceDbContext.TblUsers.Add(tblUser);
            _ecommerceDbContext.SaveChanges();
            return RedirectToAction("Index");
           


        }
    }
}