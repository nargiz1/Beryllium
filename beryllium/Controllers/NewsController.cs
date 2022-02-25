using Beryllium.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Controllers
{
    public class NewsController : Controller
    {
        private readonly AppDbContext _db;
        public NewsController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.Count = _db.News.Count();
            return View(_db.News.Take(3).ToList());
        }
        public IActionResult LoadNews(int skip)
        {
            return Json(_db.News.Skip(skip).Take(3));
        }

    }
}
