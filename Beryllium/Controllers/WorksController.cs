using Beryllium.DAL;
using Beryllium.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Controllers
{
    public class WorksController : Controller
    {
        private readonly AppDbContext dbContext;

        public WorksController(AppDbContext db)
        {
            dbContext = db;
        }

        public IActionResult Index()
        {
            return View(dbContext.Works.ToList());
        }

        public IActionResult LoadWorksAsView()
        {
            return PartialView("_WorksPartial", dbContext.Works.ToList());
        }

        public IActionResult SearchWorks(string query)
        {
            List<Work> result = dbContext.Works.Where(x => x.WorkName.ToLower().Contains(query.ToLower())).ToList();
            return PartialView("_WorksPartial", result);
        }
    }
}
