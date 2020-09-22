using MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class PeopleController : Controller
    {
        //ROUTING
        //https://localhost:1234/People/Index
        //https://localhost:1234/People/Create
        //https://localhost:1234/People/1

        //https://localhost:1234/{controller}/{action}/{id}

        [HttpGet]
        public ActionResult Index()
        {
            //MODEL
            using(MyContext ctx = new MyContext())
            {
                List<Person> model = ctx.People.ToList();

                //VIEW
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection parameters)
        {
            try
            {
                using (MyContext ctx = new MyContext())
                {
                    Person newPerson = new Person()
                    {
                        Name = parameters["Name"],
                        Surname = parameters["Surname"],
                        Email = parameters["Email"]
                    };
                    ctx.People.Add(newPerson);
                    ctx.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            using (MyContext ctx = new MyContext())
            {
                Person person = ctx.People.Where(p => p.ID == id).FirstOrDefault();
                if (person != null)
                {
                    ctx.People.Remove(person);
                    ctx.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            using (MyContext ctx = new MyContext())
            {
                Person person = ctx.People.Where(p => p.ID == id).FirstOrDefault();
                if (person != null)
                {
                    return View(person);
                }
                else
                    return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Edit(FormCollection parameters, int id)
        {
            using(MyContext ctx = new MyContext())
            {
                Person foundPerson = ctx.People.Where(p => p.ID == id).FirstOrDefault();
                if(foundPerson != null)
                {
                    foundPerson.Name = parameters["Name"];
                    foundPerson.Surname = parameters["Surname"];
                    foundPerson.Email = parameters["Email"];
                }
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
        }

    }
}