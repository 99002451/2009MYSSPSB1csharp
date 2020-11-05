using _2009MYSSPSB1csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2009MYSSPSB1csharp.Controllers
{
    public class NewProjectController : Controller
    {
        // GET: NewProject
        public ViewResult HomePage()
        {
            var context = new pdatabaseProjectNewEntities1();
            var model = context.Users.ToList();
            return View(model);
        }

        public ViewResult Login()
        {
            var context = new pdatabaseProjectNewEntities1();
            var model = context.Users.ToList();
            return View(model);
        }

        public ViewResult BooksCatalogue()
        {
            var context = new pdatabaseProjectNewEntities();
            var model = context.BookTables.ToList();
            return View(model);
        }


    }
}