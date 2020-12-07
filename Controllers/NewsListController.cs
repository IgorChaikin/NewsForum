using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsForum.Models;
using NewsForum.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsForum.Data;
using NewsForum.Data.Interfaces;
using NewsForum.Models.ObjModels;

namespace NewsForum.Controllers
{
    public class NewsListController : Controller
    {
        private readonly IAllNews _allNews;
        private readonly INewsCategory _allCategories;

        public NewsListController(IAllNews iAllNews, INewsCategory iNewsCategory)
        {
            _allNews = iAllNews;
            _allCategories = iNewsCategory;
        }

        // Print all news
        public ActionResult GetList(int? Id)
        {
            

            GetListViewModel context = new GetListViewModel();
            if (Id == null)
            {
                context.PageTitle = "Последние новости";
                context.PageDesc = "";
                context.News = _allNews.News;
            }
            else
            {
                Category c = _allCategories.getObjectCategory((int)Id);
                context.PageTitle = c.Title;
                context.PageDesc = c.Desc;
                context.News = _allNews.NewsByCategory((int)Id);
            }

            return View(context);
        }
        public ActionResult GetItem(int Id)
        {
            News news = _allNews.getObjectNews(Id);
            return View(news);
        }
    }
}
