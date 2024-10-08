using EFCoreLoading.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EFCoreLoading.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AppDbContext _db;

        public HomeController(ILogger<HomeController> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            //Explicit Loading
            Villa? villaTemp = _db.Villas.FirstOrDefault(v => v.Id == 1);

            _db.Entry(villaTemp).Collection(u => u.VillaAmenity).Load(); //this will explicitly load the villa for villaTemp record 

            VillaAmenity? villaAmenityTemp = _db.VillaAmenities.FirstOrDefault(v => v.Id == 1);
            _db.Entry(villaAmenityTemp).Reference(u => u.Villa).Load();// Since we have 1 villa let's use Reference

            //Load Villa
            List<Villa> villas = _db.Villas.ToList();

            //Eager Loading
            List<Villa> eagerVillas = _db.Villas.Include(v => v.VillaAmenity).ToList();
            
            // Lazy Loading
            //var totalVillas = villas.Count();

            //for(int i = 0; i < totalVillas; i++)
            //{
            //    villas[i].VillaAmenity = _db.VillaAmenities.Where(u => u.VillaId == villas[i].Id).ToList();
            //}
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
    }
}
