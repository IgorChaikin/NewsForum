using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsForum.Data.Interfaces;
using NewsForum.Models.ObjModels;
using NewsForum.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using NewsForum.Hubs;
using Microsoft.AspNetCore.SignalR;
using NewsForum.Models.AuthModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace NewsForum.Controllers
{
    [Authorize]
    public class EditNewsController : Controller
    {
        private readonly IAllNews _allNews;
        private readonly INewsCategory _allCategories;
        private readonly IHubContext<NewsHub> _hubContext;
        private UserManager<User> _userManager;

        public EditNewsController(IAllNews iAllNews, INewsCategory iNewsCategory, IHubContext<NewsHub> hubContext, UserManager<User> userManager)
        {
            _allNews = iAllNews;
            _allCategories = iNewsCategory;
            _hubContext = hubContext;
            _userManager = userManager;
        }

        [HttpGet]
        public ActionResult EditForm(int? Id = null)
        {
            EditFormViewModel context = new EditFormViewModel
            {
                Categories = _allCategories.AllCategories.ToList(),
                News = (Id == null) ? null : _allNews.getObjectNews((int)Id)
            };
            return View(context);
        }
        [HttpPost]
        public ActionResult EditForm(string title, string shortDescr, string img, string descr, string categoryId, string date, int? Id)
        {
            int[] d = date.Split(new char[] { '-' }).Select(el => int.Parse(el)).ToArray();

            News news = new News
            {
                Title = title,
                ShortDesc = shortDescr,
                Img = img,
                Desc = descr,
                Category = _allCategories.getObjectCategory(int.Parse(categoryId)),

                Date = new DateTime(d[0], d[1], d[2], d[3], d[4], d[5]).AddHours(
                -(
                            _userManager
                            .FindByNameAsync(User.Identity.Name)
                            .Result.TimeZoneOffset
                )
                ),
                    
                Author = User.Identity.IsAuthenticated ? User.Identity.Name : ""
            };
            if (Id == null)
            {
                _allNews.addNews(news);
            }
            else /* DATE, IMG*/
            {
                if (User.Identity.Name == _allNews.getObjectNews((int)Id).Author)
                {
                    _allNews.editNews((int)Id, news);
                }
            }
            return RedirectToAction("GetList", "NewsList");
        }
        public ActionResult DeleteNews(int Id)
        {
            if (User.Identity.Name == _allNews.getObjectNews(Id).Author)
            {
                _allNews.deleteNews(Id);
                return RedirectToAction("GetList", "NewsList");
            }
            return RedirectToAction("Login", "Register");
        }
    }
}
