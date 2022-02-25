using Beryllium.DAL;
using Beryllium.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Controllers
{
    public class NewsController : Controller
    {
        private readonly AppDbContext dbContext;

        public NewsController(AppDbContext db)
        {
            dbContext = db;
        }

        public IActionResult Index()
        {
            ViewBag.Count = dbContext.Posts.Count();
            return View(dbContext.Posts.Take(6).ToList());
        }
        public IActionResult LoadPostsAsView(int skip = 6)
        {
            return PartialView("_NewsPartial", dbContext.Posts.Skip(skip).Take(6).ToList());
        }
    }
}
