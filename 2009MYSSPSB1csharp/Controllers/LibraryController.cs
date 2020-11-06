using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class LibraryController : Controller
    {
        // GET: Library
       public ViewResult Home()
        {
            var context = new LibraryDBEntities1();
            var model = context.Logins.ToList();
            return View(model);

        }
        public ViewResult Login()
        {
            var context = new LibraryDBEntities1();
            var model = context.Logins.ToList();
            return View(model);
        }
        public ViewResult BookList()
        {
            var context = new LibraryDBEntities();
            var model = context.BookTables.ToList();
            return View(model);
        }
        public ViewResult DisplayBook()
        {
            var context = new LibraryDBEntities();
            var model = context.BookTables.ToList();
            return View(model);
        }
        public ViewResult Addbook()
        {
            var model = new BookTable();
            return View(model);
        }
        [HttpPost]
        public ActionResult Addbook(BookTable book)
        {
            var context = new LibraryDBEntities();
            context.BookTables.Add(book);
            context.SaveChanges();
            return RedirectToAction("BookList");
        }
        public ActionResult Edit(string id)
        {
            int bookId = int.Parse(id);
            var context = new LibraryDBEntities();
            var model = context.BookTables.FirstOrDefault((e) => e.bookId == bookId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(BookTable book)
        {
            var context = new LibraryDBEntities();
            var model = context.BookTables.FirstOrDefault((e) => e.bookId == book.bookId);
            model.bookTitle = book.bookTitle;
            model.bookAuthor = book.bookAuthor;
            model.bookDesc = book.bookDesc;
            model.bookCount = book.bookCount;

            context.SaveChanges();
            return RedirectToAction("BookList");
        }

        public ViewResult Contact()
        {
            var context = new LibraryDBEntities();
            var model = context.BookTables.ToList();
            return View(model);
        }
       
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult MyAction(string button)
        {
            return View("BookList");
        }
       
        public ActionResult Deletebook(string id)
        {
            int bookId = int.Parse(id);
            var context = new LibraryDBEntities();
            var model = context.BookTables.FirstOrDefault((e) => e.bookId == bookId);
            context.BookTables.Remove(model);
            context.SaveChanges();
            return RedirectToAction("BookList");
        }
    }
}