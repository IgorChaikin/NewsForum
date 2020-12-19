using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NewsForum.Data.Interfaces;
using NewsForum.Models.AuthModels;
using NewsForum.Models.ObjModels;

namespace NewsForum.Controllers
{
    [Authorize]
    public class CommentsController : Controller
    {
        private readonly IAllComments _allComments;
        private readonly IAllNews _allNews;
        private UserManager<User> _userManager;

        public CommentsController(IAllComments iAllComments, IAllNews iAllNews, UserManager<User> userManager)
        {
            _allComments = iAllComments;
            _allNews = iAllNews;
            _userManager = userManager;
        }

        [HttpPost]
        public IActionResult EditComments(string text, string date, int newsId, int? id)
        {
            int[] d = date.Split(new char[] { '-' }).Select(el => int.Parse(el)).ToArray();
            if (id == null)
            {
                Comment c = new Comment { Text = text,
                    Author = User.Identity.Name,
                    News = _allNews.getObjectNews(newsId),

                    Date = new DateTime(d[0], d[1], d[2], d[3], d[4], d[5]).AddHours(
                    -(
                        _userManager
                        .FindByNameAsync(User.Identity.Name)
                        .Result.TimeZoneOffset
                    )
                    ),
                };
                    _allComments.addComment(c);

            }
            return RedirectToAction("GetItem", "NewsList", new { id = newsId });
        }

        public IActionResult DeleteComment(int newsId, int id)
        {
            if (User.Identity.Name == _allComments.getObjectComment(id).Author)
            {
                _allComments.deleteComment((int)id);
                return RedirectToAction("GetItem", "NewsList", new { id = newsId });
            }
            return RedirectToAction("Login", "Register");
        }
    }
}
