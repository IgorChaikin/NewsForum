using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewsForum.Data.Interfaces;
using NewsForum.Models.ObjModels;

namespace NewsForum.Controllers
{
    [Authorize(Roles = "admin")]
    public class CategoryController : Controller
    {
        private readonly INewsCategory _allCategories;

        public CategoryController(INewsCategory iNewsCategory)
        {
            _allCategories = iNewsCategory;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> categories = _allCategories.AllCategoriesWithNews;
            return View(categories);
        }
        [HttpGet]
        public ActionResult EditForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EditForm(string title, string descr)
        {
            Category category = new Category
            {
                Title = title,
                Desc = descr
            };
            _allCategories.addCategory(category);
            return RedirectToAction("Index", "Category");
        }
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            if (_allCategories.getCategoryWithNews(Id).News.ToList().Count == 0)
            {
                _allCategories.deleteCategory(Id);
            }
            return RedirectToAction("Index", "Category");
        }
    }
}
