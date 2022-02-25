using Beryllium.DAL;
using Beryllium.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext dbContext;

        public HomeController(AppDbContext db)
        {
            dbContext = db;
        }

        public IActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel
            {
                sliders = dbContext.Sliders.ToList(),
                works = dbContext.Works.ToList(),
                posts = dbContext.Posts.Take(3).ToList(),
                testimonials = dbContext.Testimonials.Take(2).ToList(),
                features = dbContext.Features.ToList(),
            };

            return View(hvm);
        }


    }
}
