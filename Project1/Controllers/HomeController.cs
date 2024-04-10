using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;
using System.Diagnostics;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProjectDbContext _ProjectDbContext;


        public HomeController(ILogger<HomeController> logger, ProjectDbContext ProjectDbConext)
        {
            _logger = logger;
            _ProjectDbContext = ProjectDbConext;
        }

        public IActionResult Index()
        {
            var CourseAvg = _ProjectDbContext.CourseRanking.OrderByDescending(x => x.CourseAverageRating).Take(10).ToList();
            var CourseClick = _ProjectDbContext.Course.OrderByDescending(x => x.Clicks).Take(10).ToList();
            ViewData["CourseRankbyAvg"] = CourseAvg;

            ViewData["CourseRankbyClick"] = CourseClick;

            return View();

        }

        public async Task<JsonResult> IndexJson1()
        {
            var topRatedCourses = await _ProjectDbContext.CourseRanking.OrderByDescending(x => x.CourseAverageRating).Take(10).ToListAsync();
           


            return Json(topRatedCourses);
        }

		public async Task<JsonResult> IndexJson2()
		{
		
			var topClickedCourses = await _ProjectDbContext.Course.OrderByDescending(x => x.Clicks).Take(10).ToListAsync();


			return Json(topClickedCourses);
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
    }
}
