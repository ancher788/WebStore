using AnStore.Models;
using System.Collections.Generic;

namespace AnStore.Services
{
    public interface IDashboard
    {
        List<Category> GetAllCategories();
    }
}
