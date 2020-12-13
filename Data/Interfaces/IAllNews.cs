using NewsForum.Models.ObjModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsForum.Data.Interfaces
{
    public interface IAllNews
    {
        IEnumerable<News> News { get; }
        News getObjectNews(int newsId);
        void addNews(News news);
        void deleteNews(int newsId);
        void editNews(int newsId, News obj);
        IEnumerable<News> NewsByCategory(int categoryId);
        void deleteAllNews();
    }
}