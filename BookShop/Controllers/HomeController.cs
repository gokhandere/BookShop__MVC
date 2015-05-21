using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BookShop.Controllers
{
    public class HomeController : Controller
    {
        BookShopDBContext db = new BookShopDBContext();
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LookForBook(string SearchString)
        {
            var books = from s in db.Book
                        select s;
            if (!String.IsNullOrEmpty(SearchString))
            {
                books = books.Where(s => s.BookName.Contains(SearchString));
            }
            return View(books.ToList());
        }
        public ActionResult LookForDVD(string SearchString)
        {
            var dvds = from s in db.DVD
                           select s;
            if (!String.IsNullOrEmpty(SearchString))
            {
                dvds = dvds.Where(s => s.DVDName.Contains(SearchString));
            }
            return View(dvds.ToList());
        }
        public ActionResult LookForMusicCD(string SearchString)
        {
            var musicCDs = from s in db.MusicCD
                        select s;
            if (!String.IsNullOrEmpty(SearchString))
            {
                musicCDs = musicCDs.Where(s => s.MusicCDName.Contains(SearchString));
            }
            return View(musicCDs.ToList());
        }

        public ActionResult BuyBook(int? id, string strSoldAmount)
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
        [HttpPost, ActionName("BuyBook")]
        public ActionResult BuyBook(int id, string strSoldAmount)
        {

            Book b = db.Book.Find(id);
            if (ModelState.IsValid)
            {
                int iSoldAmount = Convert.ToInt32(strSoldAmount);
                //BookSales bs = new BookSales();                
                
                //bs.Amount = iSoldAmount;
                //bs.UserID = User.Identity.Name;
                //bs.BookID = b.id;
                //bs.Price = b.Price;
                //db.BookSales.Add(bs);
                //db.SaveChanges();
                int newSoldAmount = b.SoldAmount + iSoldAmount;
                int newStock = b.StockAmount - iSoldAmount;
                b.SoldAmount = newSoldAmount;
                b.StockAmount = newStock;

                db.Entry(b).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("LookForBook");
            }
            return View(b);
            

        }

        public ActionResult BuyDVD(int? id, string strSoldAmount)
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
        [HttpPost, ActionName("BuyDVD")]
        public ActionResult BuyDVD(int id, string strSoldAmount)
        {

            DVD dvd = db.DVD.Find(id);
            if (ModelState.IsValid)
            {
                int iSoldAmount = Convert.ToInt32(strSoldAmount);
                //BookSales bs = new BookSales();                

                //bs.Amount = iSoldAmount;
                //bs.UserID = User.Identity.Name;
                //bs.BookID = b.id;
                //bs.Price = b.Price;
                //db.BookSales.Add(bs);
                //db.SaveChanges();
                int newSoldAmount = dvd.SoldAmount + iSoldAmount;
                int newStock = dvd.StockAmount - iSoldAmount;
                dvd.SoldAmount = newSoldAmount;
                dvd.StockAmount = newStock;

                db.Entry(dvd).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("LookForDVD");
            }
            return View(dvd);


        }
        public ActionResult BuyMusicCD(int? id, string strSoldAmount)
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
        [HttpPost, ActionName("BuyMusicCD")]
        public ActionResult BuyMusicCD(int id, string strSoldAmount)
        {

            MusicCD m = db.MusicCD.Find(id);
            if (ModelState.IsValid)
            {
                int iSoldAmount = Convert.ToInt32(strSoldAmount);
                //BookSales bs = new BookSales();                

                //bs.Amount = iSoldAmount;
                //bs.UserID = User.Identity.Name;
                //bs.BookID = b.id;
                //bs.Price = b.Price;
                //db.BookSales.Add(bs);
                //db.SaveChanges();
                int newSoldAmount = m.SoldAmount + iSoldAmount;
                int newStock = m.StockAmount - iSoldAmount;
                m.SoldAmount = newSoldAmount;
                m.StockAmount = newStock;

                db.Entry(m).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("LookForMusicCD");
            }
            return View(m);


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