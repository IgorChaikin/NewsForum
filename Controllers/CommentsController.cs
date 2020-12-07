using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsForum.Data.Interfaces;
using NewsForum.Models.ObjModels;

namespace NewsForum.Controllers
{
    public class CommentsController : Controller
    {
        private readonly IAllComments _allComments;
        private readonly IAllNews _allNews;

        public CommentsController(IAllComments iAllComments, IAllNews iAllNews)
        {
            _allComments = iAllComments;
            _allNews = iAllNews;
        }

        [HttpPost]
        public IActionResult EditComments(string text, string date, int newsId, int? id)
        {
            if (User.Identity.IsAuthenticated)
            {
                int[] d = date.Split(new char[] { '-' }).Select(el => int.Parse(el)).ToArray();
                if (id == null)
                {
                    Comment c = new Comment { Text = text, 
                        Author = User.Identity.Name, 
                        News = _allNews.getObjectNews(newsId),

                        Date = new DateTime(d[0], d[1], d[2], d[3], d[4], d[5])
                        .ToUniversalTime().ToString()
                    };
                    _allComments.addComment(c);

                }
                return RedirectToAction("GetItem", "NewsList", new { id = newsId });
            }
            return RedirectToAction("Login", "Register");
        }

        public IActionResult DeleteComment(int newsId, int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (User.Identity.Name == _allComments.getObjectComment(id).Author)
                {
                    _allComments.deleteComment((int)id);
                    return RedirectToAction("GetItem", "NewsList", new { id = newsId });
                }
            }
            return RedirectToAction("Login", "Register");
        }
    }
}
