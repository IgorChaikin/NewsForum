using Microsoft.EntityFrameworkCore;
using NewsForum.Data;
using NewsForum.Data.Interfaces;
using NewsForum.Models.ObjModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Data.Repository
{
    public class NewsRepository : IAllNews
    {
        private readonly ApplicationDbContext appDBContent;

        public NewsRepository(ApplicationDbContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<News> News => 
            appDBContent.News.Include(c => c.Category);

        public News getObjectNews(int newsId) => 
            appDBContent.News.Include(c => c.Category).Include(c=>c.Comments).FirstOrDefault(p=>p.Id == newsId);

        public void addNews(News news)
        {
            appDBContent.News.AddRange(news);
            appDBContent.SaveChanges();
        }

        public void deleteNews(int newsId)
        {
            News n = appDBContent.News.Where(p => p.Id == newsId).FirstOrDefault();
            if (n != null)
            {
                appDBContent.News.Remove(n);
                appDBContent.SaveChanges();
            }
        }

        public void editNews(int newsId, News obj)
        {
            News n = appDBContent.News.Where(p => p.Id == newsId).FirstOrDefault();
            if (n != null)
            {
                n.Img = obj.Img;
                n.Title = obj.Title;
                n.ShortDesc = obj.ShortDesc;
                n.Desc = obj.Desc;
                n.Category = obj.Category;
                n.Date = obj.Date;

                appDBContent.SaveChanges();
            }
        }

        public void deleteAllNews()
        {
            if (appDBContent.News.Any())
            {
                appDBContent.News.RemoveRange(appDBContent.News);
                appDBContent.SaveChanges();
            }
        }

        public IEnumerable<News> NewsByCategory(int categoryId)=>
            appDBContent.News.Include(c => c.Category).Where(n => n.Category.Id == categoryId).ToList();
    }
}
