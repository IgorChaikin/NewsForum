using NewsForum.Models.ObjModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsForum.Data.Interfaces
{
    public interface INewsCategory
    {
        void addCategory(Category category);
        IEnumerable<Category> AllCategories { get; }
        Category getObjectCategory(int categoryId);
        void deleteAllCategories();
    }
}
