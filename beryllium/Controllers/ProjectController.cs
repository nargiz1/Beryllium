using Beryllium.DAL;
using Beryllium.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Controllers
{

    public class ProjectController : Controller
    {
        private readonly AppDbContext _db;
        public ProjectController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.Count = _db.Projects.Count();
            return View(_db.Projects.Take(6).ToList());
        }
        public IActionResult SearchProject(string query)
        {
            List<Project> result = _db.Projects.Where(x => x.Title.ToLower().Contains(query) || x.SubTitle.ToLower().Contains(query)).ToList();
            return PartialView("_ProjectsPartial", result);
        }
    }
}
