using AnStore.Data;
using AnStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AnStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public IActionResult ShowGoods(int? id)
        {
            var categoryGoods = _db.Goods.Where(x => x.CategoryId == id);
            return View(categoryGoods);
        }

        public IActionResult AboutGoods(int? id)
        {
            var specificGoods = _db.Goods.Where(x => x.Id == id).FirstOrDefault();

            return View(specificGoods);
        }

        //public void AddGoodsToCart(int? id)
        //{
        //    Operation operation = new Operation(); 
        //    var specificGoods = _db.Goods.Where(x => x.Id == id).FirstOrDefault();

        //    operation.Goods = new List<Goods> { specificGoods};

            
        //}      
        
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
