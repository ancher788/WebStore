using AnStore.Data;
using AnStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnStore.Services
{
    public class Dashboard : IDashboard
    {
        private readonly ApplicationDbContext _db;

        public Dashboard(ApplicationDbContext db)
        {
            _db = db;
        }


        public List<Category> GetAllCategories()
        {
            return _db.Categories.Select(x => new Category() { Id = x.Id, Name = x.Name }).ToList();
        }
    }
}
