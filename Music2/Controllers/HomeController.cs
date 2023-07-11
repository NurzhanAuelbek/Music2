using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Music2.Data;
using Music2.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Music2.Controllers
{
    public class HomeController : Controller
    {
		private readonly ApplicationDbContext _db;
		private readonly IWebHostEnvironment _env;

		public HomeController(ApplicationDbContext db, IWebHostEnvironment env)
		{
			_db = db;
			_env = env;
		}


		public IActionResult Index()
		{
			IEnumerable<Artist> objList = _db.Artists;
			return View(objList);
		}
		public IActionResult Artists()
        {
            return View();
        }
		public IActionResult Artist()
		{
			return View();
		}
		public IActionResult Article()
		{
			return View();
		}
		public IActionResult News()
        {
            return View();
        }
        public IActionResult Podcasts()
        {
            return View();
        }
        public IActionResult Releases()
        {
            return View();
        }
		public IActionResult Release()
		{
			return View();
		}
		[HttpGet]
		public IActionResult Download(string filename)
		{
			string path = Path.Combine(_env.WebRootPath, "music", filename);
			var stream = System.IO.File.OpenRead(path);
			return File(stream, "application/octet-stream", filename); // returns a FileStreamResult
		}


	}
}