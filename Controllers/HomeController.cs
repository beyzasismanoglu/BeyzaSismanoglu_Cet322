using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cet322_FinalProject.Models;
using Cet322_FinalProject.Data;
using Cet322_FinalProject.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Cet322_FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public async Task<IActionResult> Search()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Search(SearchViewModel searchModel)
        {
            var users = _context.Users.AsQueryable();

            if (!String.IsNullOrWhiteSpace(searchModel.SearchText))
            {
                
                    users = users.Where(b => b.UserName.Contains(searchModel.SearchText) || b.SkillName.Contains(searchModel.SearchText) || b.GameName.Contains(searchModel.SearchText));

            }
            searchModel.Result= await users.ToListAsync();
            return View(searchModel);
        }
    }
}
