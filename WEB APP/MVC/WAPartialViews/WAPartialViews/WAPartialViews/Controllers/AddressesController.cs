using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WAPartialViews.Models;

namespace WAPartialViews.Controllers
{
    public class AddressesController : Controller
    {
        // GET: Addresses
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form, int id)
        {
            using(MyContext ctx = new MyContext())
            {
                User currentUser = ctx.Users.Include(u => u.Addresses).Where(u => u.Id == id).FirstOrDefault();
                if (currentUser != null)
                {
                    currentUser.Addresses.Add(new Address()
                    {
                        City = form["City"],
                        Number = form["Number"],
                        Street = form["Street"]
                    });
                    ctx.SaveChanges();
                }
            }
            return RedirectToAction("Edit", "Users", id);
        }

    }
}