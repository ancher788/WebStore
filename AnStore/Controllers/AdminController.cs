using AnStore.Data;
using AnStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AnStore.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _appEnvironment;

        public AdminController(ApplicationDbContext db, IWebHostEnvironment appEnvironment)
        {
            _db = db;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddGoods()
        {
            ViewBag.Categories = new SelectList(_db.Categories, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddGoods(Goods goods, IFormFile uploadedFile)
        {
            goods.DateReceived = DateTime.Now;
            if (uploadedFile != null && uploadedFile.ContentType == "image/jpeg")
            {
                // путь к папке Files
                string path = "/Files/" + uploadedFile.FileName;
                goods.Imagine = path;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
            }

            if (ModelState.IsValid)
            {
                _db.Goods.Add(goods);
                await _db.SaveChangesAsync();
                return RedirectToAction("AddGoods");
            }

            return View();
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(Category category)
        {
            var existItem = _db.Categories.Where(x => x.Name == category.Name).FirstOrDefault();

            if (ModelState.IsValid)
            {
                if (existItem == null)
                {
                    _db.Categories.Add(category);
                    await _db.SaveChangesAsync();
                    var a = 1;

                    return RedirectToAction("AddCategory");
                }
            }

            return View();
        }

    }
}
