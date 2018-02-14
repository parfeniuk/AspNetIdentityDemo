using AspNetIdentityDemo.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetIdentityDemo.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<ApplicationUser> users;
            using (ApplicationUserManager userManager = 
                HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>())
            {
                users = userManager.Users;
            }
                //using (ApplicationDbContext usersDb=new ApplicationDbContext())
                //{
                //    users = usersDb.Users.ToList();
                //}
                return View(users);
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