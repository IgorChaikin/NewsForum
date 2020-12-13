using NewsForum.Data.Interfaces;
using NewsForum.Models.ObjModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsForum.Data.Repository
{
    public class CategoryRepository : INewsCategory
    {
        private readonly ApplicationDbContext appDBContent;

        public CategoryRepository(ApplicationDbContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Categories;
    
        public void addCategory(Category category)
        {
            appDBContent.Categories.AddRange(category);
            appDBContent.SaveChanges();
        }
        public Category getObjectCategory(int categoryId) =>
            appDBContent.Categories.FirstOrDefault(c => c.Id == categoryId);
        public void deleteAllCategories()
        {
            if (appDBContent.Categories.Any())
            {
                appDBContent.Categories.RemoveRange(appDBContent.Categories);
                appDBContent.SaveChanges();
            }
        }
    }
}
