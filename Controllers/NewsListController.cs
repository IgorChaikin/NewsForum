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
using Microsoft.AspNetCore.SignalR;
using NewsForum.Hubs;
using Microsoft.AspNetCore.Identity;
using NewsForum.Models.AuthModels;

namespace NewsForum.Controllers
{
    public class NewsListController : Controller
    {
        private readonly IAllNews _allNews;
        private readonly INewsCategory _allCategories;
        private readonly IHubContext<NewsHub> _hubContext;
        private readonly UserManager<User> _userManager;

        public NewsListController(IAllNews iAllNews, INewsCategory iNewsCategory, IHubContext<NewsHub> hubContext, UserManager<User> userManager)
        {
            _allNews = iAllNews;
            _allCategories = iNewsCategory;
            _hubContext = hubContext;
            _userManager = userManager;
        }

        // Print all news
        public ActionResult GetList(int? Id)
        {
            

            GetListViewModel context = new GetListViewModel();

            context.Offset = User.Identity.IsAuthenticated ? (int?)_userManager
                            .FindByNameAsync(User.Identity.Name)
                            .Result.TimeZoneOffset : null; 

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
            GetItemViewModel context = new GetItemViewModel();

            context.Offset = User.Identity.IsAuthenticated ? (int?)_userManager
                            .FindByNameAsync(User.Identity.Name)
                            .Result.TimeZoneOffset : null;

            context.News = _allNews.getObjectNews(Id);

            return View(context);
        }
    }
}
