using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tp3.Models;

namespace tp3.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        [Route ("Person/{id}")]   
        public ActionResult Index(int id)
        {
            Personal_info personal_Info = new Personal_info();
            return View(personal_Info.GetPerson(id));
       
        }
        [Route("Person/all")]

        public ActionResult all()
        {

            Personal_info personal_Info = new Personal_info();
            return View(personal_Info.GetallPerson());

        }
        
      
        [HttpPost]
        [Route("Person/search")]
        public ActionResult search(String first_name, String country)
        {
            Personal_info pi = new Personal_info();
            List<Person> Persons = pi.GetallPerson();
            foreach (Person p in Persons)
            {
                if (p.first_name == first_name && p.country == country)
                {
                    return RedirectToAction("Index",new {id = p.id});

                }
            }
            ViewBag.notFound = true;
            return View();
        }
       [HttpGet]
        [Route("Person/search")]
        public ActionResult search()
        {
            ViewBag.notFound = false;
            return View();
        }


    }
}