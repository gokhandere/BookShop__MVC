using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BookShop.Controllers
{
    public class AdminController : Controller
    {
        BookShopDBContext db = new BookShopDBContext();

        public ActionResult Index()
        {
            return View();
        }
        // GET: Admin
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult BookList()
        {
            return View(db.Book.ToList());
        }
        public ActionResult DVDList()
        {
            return View(db.DVD.ToList());
        }
        public ActionResult MusicCDList()
        {
            return View(db.MusicCD.ToList());
        }
        public ActionResult AuthorList()
        {
            return View(db.Author.ToList());
        }
        public ActionResult CategoryList()
        {
            return View(db.Category.ToList());
        }
        public ActionResult DirectorList()
        {
            return View(db.Director.ToList());
        }
        public ActionResult MusicianList()
        {
            return View(db.Musician.ToList());
        }

        [HttpGet]
        public ActionResult AddMusician()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddMusician(Musician m)
        {
            if (ModelState.IsValid)
            {
                db.Musician.Add(m);
                db.SaveChanges();
                return RedirectToAction("MusicianList");
            }
            return View(m);
        }

        [HttpGet]
        public ActionResult EditMusician(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musician m = db.Musician.Find(id);
            if (m == null)
            {
                return HttpNotFound();
            }
            return View(m);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditMusician([Bind(Include = "id,MusiciaName")] Musician m)
        {
            if (ModelState.IsValid)
            {
                db.Entry(m).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("MusicianList");
            }
            return View(m);
        }
        public ActionResult DetailsMusician(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musician m = db.Musician.Find(id);
            if (m == null)
            {
                return HttpNotFound();
            }
            return View(m);
        }
        public ActionResult DeleteMusician(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musician m = db.Musician.Find(id);
            if (m == null)
            {
                return HttpNotFound();
            }
            return View(m);
        }

        // POST: /Movies/Delete/5
        [HttpPost, ActionName("DeleteMusician")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmedMusician(int id)
        {
            Musician m = db.Musician.Find(id);
            db.Musician.Remove(m);
            db.SaveChanges();
            return RedirectToAction("MusicianList");
        }

        [HttpGet]
        public ActionResult AddDirector()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddDirector(Director d)
        {
            if (ModelState.IsValid)
            {
                db.Director.Add(d);
                db.SaveChanges();
                return RedirectToAction("DirectorList");
            }
            return View(d);
        }

        [HttpGet]
        public ActionResult EditDirector(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Director d = db.Director.Find(id);
            if (d == null)
            {
                return HttpNotFound();
            }
            return View(d);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditDirector([Bind(Include = "id,DirectorName")] Director d)
        {
            if (ModelState.IsValid)
            {
                db.Entry(d).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DirectorList");
            }
            return View(d);
        }
        public ActionResult DetailsDirector(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Director d = db.Director.Find(id);
            if (d == null)
            {
                return HttpNotFound();
            }
            return View(d);
        }
        public ActionResult DeleteDirector(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Director d = db.Director.Find(id);
            if (d == null)
            {
                return HttpNotFound();
            }
            return View(d);
        }

        // POST: /Movies/Delete/5
        [HttpPost, ActionName("DeleteDirector")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmedDirector(int id)
        {
            Director d = db.Director.Find(id);
            db.Director.Remove(d);
            db.SaveChanges();
            return RedirectToAction("DirectorList");
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category c)
        {
            if (ModelState.IsValid)
            {
                db.Category.Add(c);
                db.SaveChanges();
                return RedirectToAction("CategoryList");
            }
            return View(c);
        }
        [HttpGet]
        public ActionResult EditCategory(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category c = db.Category.Find(id);
           
            if (c == null)
            {
                return HttpNotFound();
            }
            return View(c);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCategory([Bind(Include = "id,ProductType,CategoryName")] Category c)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("CategoryList");
            }
            return View(c);
        }
        public ActionResult DetailsCategory(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category c = db.Category.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            return View(c);
        }
        public ActionResult DeleteCategory(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category c = db.Category.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            return View(c);
        }

        // POST: /Movies/Delete/5
        [HttpPost, ActionName("DeleteCategory")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Category c = db.Category.Find(id);
            db.Category.Remove(c);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
        public ActionResult AddAuthor()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult AddAuthor(Author a)
        {
            if (ModelState.IsValid)
            {
                db.Author.Add(a);
                db.SaveChanges();
                return RedirectToAction("AuthorList");
            }
            return View(a);
        }

        [HttpGet]
        public ActionResult EditAuthor(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Author author = db.Author.Find(id);
            if (author == null)
            {
                return HttpNotFound();
            }
            return View(author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditAuthor([Bind(Include = "id,AuthorName")] Author a)
        {
            if (ModelState.IsValid)
            {
                db.Entry(a).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("AuthorList");
            }
            return View(a);
        }
        public ActionResult DetailsAuthor(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Author a = db.Author.Find(id);
            if (a == null)
            {
                return HttpNotFound();
            }
            return View(a);
        }
        public ActionResult DeleteAuthor(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Author a = db.Author.Find(id);
            if (a == null)
            {
                return HttpNotFound();
            }
            return View(a);
        }

        // POST: /Movies/Delete/5
        [HttpPost, ActionName("DeleteAuthor")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmedAuthor(int id)
        {
            Author a = db.Author.Find(id);
            db.Author.Remove(a);
            db.SaveChanges();
            return RedirectToAction("AuthorList");
        }
        [HttpGet]
        public ActionResult AddBook()
        {
            ViewBag.vbAuthor = db.Author.ToList();
            ViewBag.vbCategory = db.Category.Where(i => i.ProductType == "Book").ToList();
            return View();
        }
        [HttpPost]
        public ActionResult AddBook(Book b)
        {

            ViewBag.vbAuthor = db.Author.ToList();
            ViewBag.vbCategory = db.Category.Where(i => i.ProductType == "Book").ToList();
            if (ModelState.IsValid)
            {
                db.Book.Add(b);
                db.SaveChanges();
                return RedirectToAction("BookList");
            }
            return View(b);
        }
        [HttpGet]
        public ActionResult EditBook(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book b = db.Book.Find(id);
            ViewBag.vbAuthor = db.Author.ToList();
            ViewBag.vbCategory = db.Category.Where(i => i.ProductType == "Book").ToList();
            if (b == null)
            {
                return HttpNotFound();
            }
            return View(b);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditBook([Bind(Include = "id,CategoryID,AuthorID,BookName,PublishingHouse,PublishingYear,Explanations,Price,ImagePath,StockAmount,SoldAmount")] Book b)
        {
            ViewBag.vbAuthor = db.Author.ToList();
            ViewBag.vbCategory = db.Category.Where(i => i.ProductType == "Book").ToList();
            if (ModelState.IsValid)
            {
                db.Entry(b).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("BookList");
            }
            return View(b);
        }
        public ActionResult DetailsBook(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book b = db.Book.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            return View(b);
        }
        public ActionResult DeleteBook(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book b = db.Book.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            return View(b);
        }

        // POST: /Movies/Delete/5
        [HttpPost, ActionName("DeleteBook")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmedBook(int id)
        {
            Book b = db.Book.Find(id);
            db.Book.Remove(b);
            db.SaveChanges();
            return RedirectToAction("BookList");
        }
        public ActionResult AddDVD()
        {
            ViewBag.vbDirector = db.Director.ToList();
            ViewBag.vbCategory = db.Category.Where(i => i.ProductType == "DVD").ToList();
            return View();
        }
        [HttpPost]
        public ActionResult AddDVD(DVD d)
        {

            ViewBag.vbDirector = db.Director.ToList();
            ViewBag.vbCategory = db.Category.Where(i => i.ProductType == "DVD").ToList();
            if (ModelState.IsValid)
            {
                db.DVD.Add(d);
                db.SaveChanges();
                return RedirectToAction("DVDList");
            }
            return View(d);
        }
        public ActionResult DetailsDVD(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DVD d = db.DVD.Find(id);
            if (d == null)
            {
                return HttpNotFound();
            }
            return View(d);
        }
        [HttpGet]
        public ActionResult EditDVD(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DVD d = db.DVD.Find(id);
            ViewBag.vbDirector = db.Director.ToList();
            ViewBag.vbCategory = db.Category.Where(i => i.ProductType == "DVD").ToList();
            if (d == null)
            {
                return HttpNotFound();
            }
            return View(d);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditDVD([Bind(Include = "id,CategoryID,DirectorID,DVDName,Year,IMDB,Explanations,Price,ImagePath,StockAmount,SoldAmount")] DVD d)
        {
            ViewBag.vbDirector = db.Director.ToList();
            ViewBag.vbCategory = db.Category.Where(i => i.ProductType == "DVD").ToList();
            if (ModelState.IsValid)
            {
                db.Entry(d).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DVDList");
            }
            return View(d);
        }
        
        public ActionResult DeleteDVD(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DVD d = db.DVD.Find(id);
            if (d == null)
            {
                return HttpNotFound();
            }
            return View(d);
        }

        // POST: /Movies/Delete/5
        [HttpPost, ActionName("DeleteDVD")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmedDVD(int id)
        {
            DVD d = db.DVD.Find(id);
            db.DVD.Remove(d);
            db.SaveChanges();
            return RedirectToAction("DVDList");
        }
        public ActionResult AddMusicCD()
        {
            ViewBag.vbMusician = db.Musician.ToList();
            ViewBag.vbCategory = db.Category.Where(i => i.ProductType == "MusicCD").ToList();
            return View();
        }
        [HttpPost]
        public ActionResult AddMusicCD(MusicCD m)
        {

            ViewBag.vbMusician = db.Musician.ToList();
            ViewBag.vbCategory = db.Category.Where(i => i.ProductType == "MusicCD").ToList();
            if (ModelState.IsValid)
            {
                db.MusicCD.Add(m);
                db.SaveChanges();
                return RedirectToAction("MusicCDList");
            }
            return View(m);
        }
        [HttpGet]
        public ActionResult EditMusicCD(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MusicCD m = db.MusicCD.Find(id);
            ViewBag.vbMusician = db.Musician.ToList();
            ViewBag.vbCategory = db.Category.Where(i => i.ProductType == "MusicCD").ToList();
            if (m == null)
            {
                return HttpNotFound();
            }
            return View(m);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditMusicCD([Bind(Include = "id,CategoryID,MusicianID,MusicCDName,Year,Explanations,Price,ImagePath,StockAmount,SoldAmount")] MusicCD m)
        {
            ViewBag.vbMusician = db.Musician.ToList();
            ViewBag.vbCategory = db.Category.Where(i => i.ProductType == "MusicCD").ToList();
            if (ModelState.IsValid)
            {
                db.Entry(m).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("MusicCDList");
            }
            return View(m);
        }
        public ActionResult DetailsMusicCD(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MusicCD m = db.MusicCD.Find(id);
            if (m == null)
            {
                return HttpNotFound();
            }
            return View(m);
        }
        public ActionResult DeleteMusicCD(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MusicCD m = db.MusicCD.Find(id);
            if (m == null)
            {
                return HttpNotFound();
            }
            return View(m);
        }

        // POST: /Movies/Delete/5
        [HttpPost, ActionName("DeleteMusicCD")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmedMusicCD(int id)
        {
            MusicCD m = db.MusicCD.Find(id);
            db.MusicCD.Remove(m);
            db.SaveChanges();
            return RedirectToAction("MusicCDList");
        }
       
    }
}
