using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WAPartialViews.Models;

namespace WAPartialViews.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            using(MyContext ctx = new MyContext())
            {
                List<User> users = ctx.Users.ToList();
                return View(users);
            }            
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            using(MyContext ctx = new MyContext())
            {
                ctx.Users.Add(new Models.User()
                {
                    Name = form["Name"],
                    Surname = form["Surname"]
                });
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            using(MyContext ctx = new MyContext())
            {
                User user = ctx.Users
                                .Include(u => u.Addresses)
                                .Where(u => u.Id == id)
                                .FirstOrDefault();
                return View(user);
            }
        }

    }
}