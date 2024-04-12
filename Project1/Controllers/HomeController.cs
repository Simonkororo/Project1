using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.DTO;
using Project1.Models;
using Project1.ViewModel;
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
            var quantityTotals = _ProjectDbContext.OrderDetail
                .GroupBy(x => x.CourseID)
                .Select(g => new { CourseID = g.Key, TotalQuantity = g.Sum(x => x.Quantity) }); // �N���G�ഫ�� List

            var courses = (from c in _ProjectDbContext.Course
                           join cr in _ProjectDbContext.CourseRanking on c.CourseID equals cr.CourseID into joined
                           from subcr in joined.DefaultIfEmpty()
                           let totalQuantityRecord = quantityTotals.FirstOrDefault(q => q.CourseID == c.CourseID)
                           let totalQuantity = totalQuantityRecord != null ? totalQuantityRecord.TotalQuantity : 0
                           select new CourseRankViewModel
                           {
                               CourseID = c.CourseID,
                               TrainerID = c.TrainerID,
                               Clicks = c.Clicks,
                               CourseAverageRating = subcr != null ? subcr.CourseAverageRating : 0,
                               TotalQuantity = totalQuantity
                           }); // �N LINQ to Entities �ഫ�� LINQ to Objects

            return View(courses);
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
