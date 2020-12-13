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
        void deleteCategory(int categoryId);
        IEnumerable<Category> AllCategories { get; }
        IEnumerable<Category> AllCategoriesWithNews { get; }
        Category getObjectCategory(int categoryId);
        Category getCategoryWithNews(int categoryId);
        void deleteAllCategories();
    }
}
